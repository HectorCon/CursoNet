using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    [Route("[controller]")]
    public class Clase1 : Controller
    {
        #region  " tipo de datos"
        // GET: Clase1
        [HttpGet]
        public int Index()
        {
            string strVar;
            int intVar;
            bool blnVar;
            long longVar;
            float floatVar;
            double doubleVar;
            decimal decimalVar;
            char charVar;

            strVar = "cadena de caracteres";
            intVar = 1;
            blnVar = true;
            longVar = 0;
            floatVar = 0;
            doubleVar = 0.1;
            decimalVar = 123;
            charVar = 'v';


            return intVar;
        }

        [HttpGet("string")]
        public string returnString()
        {
            string strVar;
            strVar = "{cadena: 'cadena de caracteres'}";
            return strVar;
        }

        [HttpGet("bool")]
        public bool returnBool()
        {
            bool blnVar;
            blnVar = true;
            return blnVar;
        }

        [HttpGet("long")]
        public long returnLong()
        {
            long longVar;
            longVar = 0;
            return longVar;
        }

        [HttpGet("float")]
        public float returnFloat()
        {
            float floatVar;
            floatVar = 0;
            return floatVar;
        }

        [HttpGet("double")]
        public double returnDouble()
        {
            double doubleVar;
            doubleVar = 0.1;
            return doubleVar;
        }

        [HttpGet("decimal")]
        public decimal returnDecimal()
        {
            decimal decimalVar;
            decimalVar = 0;
            return decimalVar;
        }


        [HttpGet("char")]
        public char returnChar()
        {
            char charVar;
            charVar = 'a';
            return charVar;
        }

        #endregion


        #region "Despues"
        // GET: Clase1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clase1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clase1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clase1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clase1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clase1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clase1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
    #endregion
}
