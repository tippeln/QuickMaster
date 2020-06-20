//DbContextを継承するための名前空間定義
using Microsoft.EntityFrameworkCore;

namespace QuickMaster.Models
{
    //DbContextクラスを継承
    public class MyContext:DbContext
    {
        //コンストラクター
        public MyContext(DbContextOptions<MyContext> options)
            : base(options) { }
        //モデルクラスへのアクセサー
        public DbSet<Book> Book { get; set; }
    }
}
