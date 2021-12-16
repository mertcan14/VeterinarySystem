using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TransactionsManager : ITransactionsService
    {
        ITransactionsDal _transactionsDal;
        IInComeService _inComeService;

        public TransactionsManager(ITransactionsDal transactionsDal, IInComeService inComeService)
        {
            _transactionsDal = transactionsDal;
            _inComeService = inComeService;
        }

        [ValidationAspect(typeof(TransactionsValidator))]
        public IResult Add(Transactions transactions)
        {
            transactions.AddedDate = DateTime.Now;
            _transactionsDal.Add(transactions);
            InCome newInCome = new InCome();
            newInCome.AddedDate = transactions.AddedDate;
            newInCome.Price = transactions.Price;
            newInCome.Id = 0;
            var result2 = _inComeService.Add(newInCome);
            if (result2.Success)
            {
                return new SuccessResult(Messages.AddedSuccess);
            }
            return new ErrorResult(Messages.AddedError);
        }

        public IResult Delete(int id)
        {
            var transaction = _transactionsDal.Get(t => t.Id == id);
            _transactionsDal.Delete(transaction);
            _inComeService.DeleteByDate(transaction.AddedDate);
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Transactions>> GetAll()
        {
            return new SuccessDataResult<List<Transactions>>(Messages.ListedSuccess, _transactionsDal.GetAll());
        }

        public IDataResult<List<TransactionsDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<TransactionsDetailDto>>(Messages.ListedSuccess, _transactionsDal.getAllDetail());
        }

        public IDataResult<Transactions> GetById(int id)
        {
            return new SuccessDataResult<Transactions>(Messages.ListedSuccess, _transactionsDal.Get(t => t.Id == id));
        }

        [ValidationAspect(typeof(TransactionsValidator))]
        public IResult Update(Transactions transactions)
        {
            _transactionsDal.Update(transactions);
            var newInCome = _inComeService.GetByAddedDate(transactions.AddedDate);
            newInCome.Data.Price = transactions.Price;
            var result2 = _inComeService.Update(newInCome.Data);
            if (result2.Success)
            {
                return new SuccessResult(Messages.UpdateSuccess);
            }
            return new ErrorResult(Messages.UpdateError);
        }
    }
}
