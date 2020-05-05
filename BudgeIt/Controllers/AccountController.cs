using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgeIt.Models;
using BudgeIt.Models.ViewModels;

namespace BudgeIt.Controllers
{
    public class AccountController : Controller
    {
        private ICheckingsRepository CheckingsRepository;
        private ISavingsRepository SavingsRepository;
        private IDebtRepository DebtRepository;
        public int PageSize = 5;
        public AccountController(ICheckingsRepository CheckingsRepo, ISavingsRepository SavingsRepo, IDebtRepository DebtRepo)
        {
            CheckingsRepository = CheckingsRepo;
            SavingsRepository = SavingsRepo;
            DebtRepository = DebtRepo;
        }

        [HttpGet]
        public ViewResult Checkings(string category, int productPage = 1)
        => View(new ListViewModel
        {
            Checkings = CheckingsRepository.Checkings
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.Date)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                    CheckingsRepository.Checkings.Count() :
                    CheckingsRepository.Checkings.Where(e =>
                      e.Category == category).Count()
            },
            CurrentCategory = category
        });

        //public AccountController(ISavingsRepository SavingsRepo)
        //{
        //    SavingsRepository = SavingsRepo;
        //}

        [HttpGet]
        public ViewResult Savings(string category, int productPage = 1)
        => View(new ListViewModel
        {
            Savings = SavingsRepository.Savings
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.Date)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                    SavingsRepository.Savings.Count() :
                    SavingsRepository.Savings.Where(e =>
                      e.Category == category).Count()
            },
            CurrentCategory = category
        });

        //public AccountController(IDebtRepository DebtRepo)
        //{
        //    DebtRepository = DebtRepo;
        //}
        [HttpGet]
        public ViewResult Debt(string category, int productPage = 1)
        => View(new ListViewModel
        {
            Debt = DebtRepository.Debt
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.Date)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                    DebtRepository.Debt.Count() :
                    DebtRepository.Debt.Where(e =>
                      e.Category == category).Count()
            },
            CurrentCategory = category
        });
    }
}