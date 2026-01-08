using System;
using System.Data;
using FormFlow.DL.Repositories;

namespace FormFlow.BL
{
    public class RoomBL
    {
        // Reference to the Data Layer
        private readonly RoomDL _roomDL = new RoomDL();

        // 1. GET ALL ROOMS (Refreshes the DataGridView)
        public DataTable GetAllRooms()
        {
            try
            {
                return _roomDL.GetAllRooms();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // 2. ADD NEW ROOM
        public void AddRoom(int roomNo, string status)
        {
            // Logic: Prevent negative room numbers or zero
            if (roomNo > 0)
            {
                _roomDL.AddRoom(roomNo, status);
            }
            else
            {
                throw new Exception("Please enter a valid Room Number.");
            }
        }

        // 3. SEARCH ROOM
        public DataTable SearchRoom(int roomNo)
        {
            // Instead of custom SQL, we filter the existing room list for speed
            DataTable dt = _roomDL.GetAllRooms();
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"RoomNo = {roomNo}";
            return dv.ToTable();
        }

        // 4. UPDATE ROOM STATUS (Active/Inactive)
        public void UpdateRoom(int roomNo, string status)
        {
            if (roomNo > 0)
            {
                _roomDL.UpdateRoom(roomNo, status);
            }
        }

        // 5. DELETE ROOM
        public void DeleteRoom(int roomNo)
        {
            if (roomNo > 0)
            {
                _roomDL.DeleteRoom(roomNo);
            }
        }

       
           

            public DataTable ListAllRoomStatuses()
            {
                // You can add validation here, e.g., checking if the hostel is closed
                return _roomDL.GetAvailableRoomsFromDB();
            }
        
        // --- SMART INTEGRATION METHODS ---

        // 6. FETCH AVAILABLE ROOMS (For New Student Dropdown)
        public DataTable GetAvailableRooms()
        {
            // This pulls only rooms that are Active='Yes' and Booked='No'
            return _roomDL.GetAvailableRooms();
        }

        // 7. BOOK/UNBOOK ROOM
        public void UpdateRoomBookingStatus(int roomNo, string bookedStatus)
        {
            // Automatically called when a student registers or leaves
            _roomDL.UpdateRoomBookingStatus(roomNo, bookedStatus);
        }


        // Inside RoomBL.cs
        public DataTable GetStudentFees(int id) => _roomDL.GetFeesByStudentId(id);

        public bool ProcessPayment(int feeId) => _roomDL.MarkFeeAsPaid(feeId);
    }
}