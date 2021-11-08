using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public Result Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult("Başarı ile eklendi.");
        }

        public Result Delete(int id)
        {
            _companyDal.Delete(_companyDal.Get(c=> c.Id==id));
            return new SuccessResult("Başarı ile silindi.");
        }

        public Result GetAll()
        {
            return new SuccessDataResult<List<Company>>("Başarı ile listelendi.",_companyDal.GetAll());
        }

        public Result GetById(int id)
        {
            return new SuccessDataResult<Company>("Başarı ile getirildi.", _companyDal.Get(c=> c.Id==id));
        }

        public Result Update(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult("Başarı ile güncellendi.");
        }
    }
}
