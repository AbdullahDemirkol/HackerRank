

//https://academy.patika.dev/tr/courses/c-projeleri/voting-uygulamasi

using Project_11.Business.Abstract;
using Project_11.Business.Concrete;
using Project_11.DataAccess.InMemory.Concrete;
using Project_11.Entity;

IUserService userService=new UserManager(new UserDal());
ICategoryService categoryService = new CategoryManager(new CategoryDal());
Console.WriteLine("Oylama Programına Hoşgeldiniz.");
IsLogging:

Console.WriteLine( "1- Kayıt Ol\n" +
                    "2- Giriş Yap");
var choice=Console.ReadLine();
switch (choice)
{
    case "1":
        Console.WriteLine("Kullanıcı Adınızı Giriniz:");
        User newUser = new User();
        newUser.Username = Console.ReadLine();
        Console.WriteLine("Kullanıcı Şifrenizi Giriniz:");
        newUser.Password = Console.ReadLine();
        bool isRegister= userService.RegisterUser(newUser);
        if (isRegister)
        {
            Console.WriteLine("Başarıyla Kayıt Açıldı.");
        }
        else
        {
            Console.WriteLine("Kayıt Sırasında Hata Oluştu!!");
        }
        goto IsLogging;
    case "2":
        Console.WriteLine("Kullanıcı Adınızı Giriniz:");
        var username=Console.ReadLine();
        Console.WriteLine("Kullanıcı Şifrenizi Giriniz:");
        var password=Console.ReadLine();
        bool isLogging = userService.IsAuthenticated(username, password);
        if (isLogging)
        {
            Console.WriteLine("Giriş İşlemi Başarılı.\n");
            goto SuccessLogging;
        }
        else
        {
            Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı!!!");
            goto IsLogging;
        }
    default:
        Console.WriteLine("Hatalı Tuşlama Yapıldı.");
        goto IsLogging;
}
SuccessLogging:
List<Category> categories = categoryService.GetCategories();
Console.WriteLine("Oy Vermek İstediğiniz Kategorinin Numarasını Yazınız:");
foreach (var category in categories)
{
    Console.WriteLine(category.Id+"- "+category.CategoryName);
}
choice = Console.ReadLine();
try
{
    var selectCategory = categories.Find(p => p.Id == Convert.ToInt32(choice));
    if (selectCategory!=null)
    {
        selectCategory.Vote();
        Console.WriteLine("Oylama İşlemi Başarıyla Gerçekleşti.\n" +
            "Oylama Yaptığınız İçin Teşekkürler :)");
    }
}
catch (Exception)
{
    Console.WriteLine("Hatalı Tuşlama Yapıldı.");
    goto SuccessLogging;
}
Console.WriteLine("Alınan Oylar Şu Şekildedir");
foreach (var category in categories)
{
    Console.WriteLine(category.CategoryName+": "+category.GetVoteCount());
}
