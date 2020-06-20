//扶養なusingは予め削除。右クリック→コンテキストメニュー→usingの削除と並べ替え
using Microsoft.AspNetCore.Mvc;
using QuickMaster.Models;

namespace QuickMaster.Controllers
{
    //コントローラークラスは、Controllerクラスを継承する
    public class HelloController : Controller
    {
        //アクションメソッド（indexアクション）
        //1つ以上のアクションを束ねたクラスがコントローラー
        public IActionResult Index()
        {
            //結果処理の方法を宣言
            return Content("こんにちは、世界！");
        }
        public IActionResult Greet()
        {
            //ビュー変数（テンプレートに埋め込む値）を準備
            ViewBag.Message = "HelloWorld！";
            //テンプレートを呼び出す
            //Vews/コントローラー名/アクション名.cshtml
            //Vews/Hello/Greet.cshtml  
            return View();
            //テンプレート名↓は変えられる/Vews/Hello/Hoge.cshtml
            //return View("Hoge");
        }

        private readonly MyContext _context;
        //コンテキストクラスを取得
        public HelloController(MyContext context)
        {
            this._context = context;
        }
        public IActionResult List()
        {
            //書籍情報をビューに渡す
            return View(this._context.Book);
        }
    }

}
