using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        private MediaOrganiserContext context = new MediaOrganiserContext();
        private GenericRepository<Drive> driveRepository;
        private GenericRepository<Folder> folderRepository;
        private GenericRepository<Item> itemRepository;

        public GenericRepository<Drive> DriveRepository
        {
            get
            {
                if (this.driveRepository == null)
                {
                    this.driveRepository = new GenericRepository<Drive>(context);
                }
                return driveRepository;
            }
        }

        public GenericRepository<Folder> FolderRepository
        {
            get
            {

                if (this.folderRepository == null)
                {
                    this.folderRepository = new GenericRepository<Folder>(context);
                }
                return folderRepository;
            }
        }

        public GenericRepository<Item> ItemRepository
        {
            get
            {
                if (this.itemRepository == null)
                {
                    this.itemRepository = new GenericRepository<Item>(context);
                }
                return itemRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
