using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GradeManager : IGradeService
    {
        IGradeDal _gradeDal;

        public GradeManager(IGradeDal gradeDal)
        {
            _gradeDal = gradeDal;
        }

        public IResult Add(Grade grade)
        {
            _gradeDal.Add(grade);
            return new SuccessResult("Başarı ile eklendi.");
        }

        public IResult Delete(int id)
        {
            _gradeDal.Delete(_gradeDal.Get(g=> g.Id == id));
            return new SuccessResult("Başarı ile silindi");
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Grade>>("Başarı ile listelendi.", _gradeDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Grade>(_gradeDal.Get(g=> g.Id == id));
        }

        public IResult Update(Grade grade)
        {
            _gradeDal.Update(grade);
            return new SuccessResult("Başarı ile güncellendi.");
        }
    }
}
