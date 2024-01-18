using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MILILAssesment.Data;
using MILILAssesment.Models;
using MILILAssesment.Models.Entities;


namespace MILILAssesment.Controllers
{
    public class PRBookController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public PRBookController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var prBooks = await dbContext.tblPRBookInfo.ToListAsync();

            return View(prBooks);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(PRBookInfoViewModel prbook)
        {
            if (ModelState.IsValid)
            {
                // Map ViewModel to Entity (You may use AutoMapper or manual mapping)
                var prBookEntity = new Models.Entities.PRBookInfo
                {
                    ReqNo = prbook.ReqNo,
                    ReqDate = prbook.ReqDate,
                    ReqBy = prbook.ReqBy,
                    ReqQty = prbook.ReqQty,
                    IssuedQty = prbook.IssuedQty,
                    OfficeCode = prbook.OfficeCode,
                    IssuedDate = prbook.IssuedDate,
                    Status = prbook.Status,
                    UserName = prbook.UserName,
                    EntryDate = prbook.EntryDate,
                    ReqbyTierCode = prbook.ReqbyTierCode,
                    UpdateUserName = prbook.UpdateUserName,
                    UpdateEntryDate = prbook.UpdateEntryDate,
                    EntryWSIP = prbook.EntryWSIP,
                    UpdateWSIP = prbook.UpdateWSIP,
                    Locked = prbook.Locked,
                    Active = prbook.Active,
                    Archive = prbook.Archive
                };

                // Add entity to DbContext and save changes
                await dbContext.tblPRBookInfo.AddAsync(prBookEntity);
                await dbContext.SaveChangesAsync();

                // Optionally, you can return a different action or view after successful addition
                return RedirectToAction("Index");
            }

            // If ModelState is not valid, return to the create view with validation errors
            return View("Add", prbook);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var prBook = await dbContext.tblPRBookInfo.FindAsync(id);

            return View(prBook);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PRBookInfo pRBookView)
        {
            var pRBook = await dbContext.tblPRBookInfo.FindAsync(pRBookView.Id);

            if(pRBook is not null)
            {
                pRBook.ReqNo = pRBookView.ReqNo;
                pRBook.ReqDate = pRBookView.ReqDate;
                pRBook.ReqBy = pRBookView.ReqBy;
                pRBook.ReqQty = pRBookView.ReqQty;
                pRBook.IssuedQty = pRBookView.IssuedQty;
                pRBook.OfficeCode = pRBookView.OfficeCode;
                pRBook.IssuedDate = pRBookView.IssuedDate;
                pRBook.Status = pRBookView.Status;
                pRBook.UserName = pRBookView.UserName;
                pRBook.EntryDate = pRBookView.EntryDate;
                pRBook.ReqbyTierCode = pRBookView.ReqbyTierCode;
                pRBook.UpdateUserName = pRBookView.UpdateUserName;
                pRBook.UpdateEntryDate = pRBookView.UpdateEntryDate;
                pRBook.EntryWSIP = pRBookView.EntryWSIP;
                pRBook.UpdateWSIP = pRBookView.UpdateWSIP;
                pRBook.Locked = pRBookView.Locked;
                pRBook.Active = pRBookView.Active;
                pRBook.Archive = pRBookView.Archive;
                await dbContext.SaveChangesAsync(); 

            }
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Delete(int id)
        {
            var pRBook=await dbContext.tblPRBookInfo
                .AsNoTracking()
                .FirstOrDefaultAsync(x=>x.Id==id);
            if (pRBook is not null)
            {
                dbContext.tblPRBookInfo.Remove(pRBook);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Search(string RegNo)
        {
            return View("Index", await dbContext.tblPRBookInfo.Where(x => x.ReqNo.Contains(RegNo)).ToListAsync());
        }

        public async Task<IActionResult> Detail(int id)
        {
            var prBook = await dbContext.tblPRBookInfo.FindAsync(id);

            return View(prBook);
        }

    }
}
