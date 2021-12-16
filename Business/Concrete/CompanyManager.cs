using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
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

        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _companyDal.Delete(_companyDal.Get(c=> c.Id==id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<Company> Get()
        {
            return new SuccessDataResult<Company>(Messages.ListedSuccess, _companyDal.GetAll().First());
        }

        public IDataResult<List<Company>> GetAll()
        {
            return new SuccessDataResult<List<Company>>(Messages.ListedSuccess,_companyDal.GetAll());
        }

        public IDataResult<Company> GetById(int id)
        {
            return new SuccessDataResult<Company>(Messages.ListedSuccess, _companyDal.Get(c=> c.Id==id));
        }

        public IResult Update(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
