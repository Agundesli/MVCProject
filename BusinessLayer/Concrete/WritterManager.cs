using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WritterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WritterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        //    GenericRepository<Writer> repo = new GenericRepository<Writer>();
        //    public List<Writer> GetAll()
        //    {
        //        return repo.List();
        //    }
        //    public void WriterAddBL(Writer p))
        //    {
        //        if (p.WriterName == "" || p.WriterName.Length < 3 || p.WriterSurname == "")
        //        {
        //            Console.WriteLine("Hata");
        //        }
        //        else
        //        {
        //            repo.Insert(p);
        //        }
        //    }
        public Writer GetById(int Id)
        {
            return _writerDal.Get(x=>x.WriterId==Id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
