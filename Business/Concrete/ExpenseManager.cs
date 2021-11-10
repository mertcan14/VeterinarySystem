using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        IExpenseDal _expenseDal;

        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }

        [ValidationAspect(typeof(ExpenseValidator))]
        public IResult Add(Expense expense)
        {
            _expenseDal.Add(expense);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _expenseDal.Delete(_expenseDal.Get(e=> e.Id==id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Expense>>(Messages.ListedSuccess, _expenseDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Expense>(Messages.ListedSuccess, _expenseDal.Get(e=> e.Id==id));
        }

        [ValidationAspect(typeof(ExpenseValidator))]
        public IResult Update(Expense expense)
        {
            _expenseDal.Update(expense);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
