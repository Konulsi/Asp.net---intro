namespace Asp_intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            //bu o demekdrki menim proyektim MVC proyekt olacaq,model view controller mentiqile ishleyecek
            builder.Services.AddControllersWithViews();






            var app = builder.Build();


            //burada routeni duzeldirik.default olaraq harani achsin deye.
            //bashqa yeri achmaq isteyirikse, /- slash qoyub controllerin adini yazaraq gosteriririk
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                //burada ilk olaraq home sehifesi,homun indexi,idsine gore datanin detaili(? bu ishere ise null olub olmamasina gore qoyuruq)
            app.Run();
        }
    }
}