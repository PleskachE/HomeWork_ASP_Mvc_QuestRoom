using QuestRoom.Data.Abstractions;
using QuestRoom.Data.Abstractions.Repositories;
using QuestRoom.Data.Repositories;

namespace QuestRoom.Data
{
    public class DataUnitOfWork : IDataUnitOfWork
    {
        private readonly DataDbContext _context;

        private IRoomRepository _roomRepository;
        private IPictureRepository _pictureRepository;

        public DataUnitOfWork(string connectionString)
        {
            _context = new DataDbContext(connectionString);
        }

        public IRoomRepository RoomRepository
        {
            get
            {
                if (_roomRepository == null)
                {
                    _roomRepository = new RoomRepository(_context);
                }

                return _roomRepository;
            }
        }

        public IPictureRepository PictureRepository
        {
            get
            {
                if (_pictureRepository == null)
                {
                    _pictureRepository = new PictureRepository(_context);
                }
                return _pictureRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
