using Leave_Mangement.Contracts;
using Leave_Mangement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Mangement.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {

        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            var leaveHistory = _db.LeaveHistories.ToList();
            return leaveHistory;
        }

        public LeaveHistory FindById(int id)
        {
            var leaveHistory = _db.LeaveHistories.Find(id);
            return leaveHistory;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
