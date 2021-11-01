using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GenusManager : IGenusService
    {
        IGenusDal _genusDal;

        public GenusManager(IGenusDal genusDal)
        {
            _genusDal = genusDal;
        }

        public IResult Add(Genus genus)
        {
            _genusDal.Add(genus);
            return new SuccessResult("Başarı ile eklendi");
        }

        public IResult Delete(int id)
        {
            _genusDal.Delete(_genusDal.Get(g=> g.Id==id));
            return new SuccessResult("Başarı ile silindi");
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Genus>>("Başarı ile listelendi.", _genusDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Genus>("Başarı ile getirildi", _genusDal.Get(g=> g.Id == id));
        }

        public IResult Update(Genus genus)
        {
            _genusDal.Update(genus);
            return new SuccessResult("Başarı ile güncellendi");
        }
    }
}
