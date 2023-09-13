
//https://academy.patika.dev/tr/courses/c-projeleri/atm-uygulamasi

using Project_11.Business.Abstract;
using Project_11.Business.Concrete;
using Project_11.DataAccess.InMemory.Concrete;
using Project_11.Entity;
using Project_12.Business.Abstract;
using Project_12.Business.Concrete;
using Project_12.DataAccess.InMemory.Concrete;
using Project_12.Entity;
using Project_12.Services;

IUserService userService = new UserManager(new UserDal());
IAccountService accountService=new AccountManager(new AccountDal());
ICreditService creditService=new CreditManager(new CreditDal());
LoggerService loggerService=new LoggerService();

Console.WriteLine("Bankamatiğe Hoşgeldiniz.");
IsLogging:

Console.WriteLine("1- Kayıt Ol\n" +
                    "2- Giriş Yap");
var choice = Console.ReadLine();
User user=new User();
switch (choice)
{
    case "1":
        bool isRegister=RegisterAction(); 
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
        var isLogging = LoginAction();
        if (isLogging)
        {
            Console.WriteLine("Giriş İşlemi Başarılı.\n");
            break;
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

Console.WriteLine("Yapmak istenilen işlemi tuşlayınız:\n" +
    "1- Para Çekme\n" +
    "2- Para Yatırma\n" +
    "3- Krediler\n" +
    "4- Çıkış Yap");
choice= Console.ReadLine();
switch (choice)
{
    case "1":
        WithDrawMoney();
        goto SuccessLogging;
    case "2":
        DepositMoney();
        goto SuccessLogging;
    case "3":
        Credits();
        goto SuccessLogging;
    case "4":
        user=new User();
        goto IsLogging;
    default:
        break;
}


bool RegisterAction()
{
    Console.WriteLine("Kullanıcı Adınızı Giriniz:");
    User newUser = new User();
    newUser.Username = Console.ReadLine();
    Console.WriteLine("Kullanıcı Şifrenizi Giriniz:");
    newUser.Password = Console.ReadLine();
    return userService.RegisterUser(newUser);
}

bool LoginAction()
{
    Console.WriteLine("Kullanıcı Adınızı Giriniz:");
    var username = Console.ReadLine();
    Console.WriteLine("Kullanıcı Şifrenizi Giriniz:");
    var password = Console.ReadLine();
    var isLogging= userService.IsAuthenticated(username, password);
    if (isLogging) 
    { 
        user=userService.GetUser(username);
        accountService = new AccountManager(new AccountDal(user.Account));
        creditService = new CreditManager(new CreditDal(user.Account.Credits));
    }
    else
    {
        loggerService.Logger(DateTime.Now.ToString("dd.MM.yyyy HH:mm") + $" Hatalı Giriş Yapıldı. Yapılan Deneme:{username}(Kullanıcı Adı), {password}(Şifre)");
    }
    return isLogging;
}

void WithDrawMoney()
{
    try
    {
        Console.WriteLine("Ne kadar Para Çekmek İstiyorsunuz({0} Hesabınızda Bulunan Miktardır):", user.Account.GetMoney());
        var money = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen Bekleyiniz...");
        var isDraw = accountService.WithDrawMoney(money); 
        if (isDraw)
        {
            Console.WriteLine("İstenilen Para Başarılı Bir Şekilde Çekildi.");
        }
        else
        {
            Console.WriteLine("Para Çekerken Bi Hata Oluştu.");
        }
    }
    catch (Exception)
    {

        Console.WriteLine("Para Çekerken Bi Hata Oluştu.");
    }
}

void DepositMoney()
{
    try
    {
        Console.WriteLine("Ne kadar Para Yatırmak İstiyorsunuz({0} Hesabınızda Bulunan Miktardır): \n", user.Account.GetMoney());
        var money = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen Bekleyiniz...");
        var isDraw = accountService.DepositMoney(money);
        if (isDraw)
        {
            Console.WriteLine("İstenilen Para Başarılı Bir Şekilde Çekildi.");
        }
        else
        {
            Console.WriteLine("Para Çekerken Bi Hata Oluştu.");
        }
    }
    catch (Exception)
    {

        Console.WriteLine("Para Çekerken Bi Hata Oluştu.");
    }
}

void Credits()
{
    Credits:
    Console.WriteLine("Ödemek İstediğiniz Krediyi Seçiniz:\n" +
        "1- Kredi Bilgilerini Görüntüle\n" +
        "2- Kredi Çek\n" +
        "3- Krediyi Yatır\n" +
        "4- Anamenüye Dön");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            ShowCredits();
            goto Credits;
        case "2":
            try
            {
                var isAdded = AddCredit();
                if (isAdded)
                {
                    Console.WriteLine("Kredi Başarılı Bir Şekilde Çekildi.");
                    goto Credits;
                }
                else
                {
                    Console.WriteLine("Kredi Çekiminde Hata Oluştu.");
                    goto Credits;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Kredi Çekiminde Hata Oluştu.");
                goto Credits;
            }
        case "3":
            try
            {
                PaidCredits();
                goto Credits;
            }
            catch (Exception)
            {
                Console.WriteLine("Kredi Ödemesinde Hata Oluştu.");
                goto Credits;
            }
        case "4":
            return;
        default:
            Console.WriteLine("Hatalı Tuşlama Yapıldı.");
            goto Credits;
    }

}

void PaidCredits()
{
    PayCredit:
    Console.WriteLine("Ödemek İstenilen Krediyi Seçiniz:");
    var credits = creditService.GetCredits();
    for (int i = 0; i < credits.Count; i++)
    {
        Console.WriteLine($"{credits[i].Id}- Numaralı, Toplam Tutarı {credits[i].TotalCreditMoney}, " +
            $"Kalan Borcu {credits[i].RemainingTotalCreditMoney} ve Bu Aylık Yatırılması Gereken Tutar {credits[i].RemainingCreditMoneyThisMonth}");
    }
    try
    {
        var choice = Convert.ToInt32(Console.ReadLine());
        if (credits.Any(p=>p.Id==choice))
        {
            Console.WriteLine("Ödemek İstenilen Tutarı Giriniz:");
            var payMoney = Convert.ToDouble(Console.ReadLine());
            var isPaid = creditService.PayCredit(choice, payMoney);
            Console.WriteLine(isPaid);
        }
        else
        {
            Console.WriteLine("Ödeme İşlemi Hatalı Girildi.");
            goto PayCredit;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Ödeme İşlemi Hatalı Girildi.");
        goto PayCredit;
    }
}

bool AddCredit()
{
    try
    {
        Console.WriteLine("Ne Kadarlık Kredi Çekmek İstersiniz:");
        var totalCreditMoney = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Kaç Taksit Yapmak İstersiniz:");
        var totalCreditCount = Convert.ToInt32(Console.ReadLine());
        Credit credit = new Credit(totalCreditMoney, totalCreditCount);
        var isAddedCreditService= creditService.AddCredit(credit);
        if (isAddedCreditService)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    catch (Exception)
    {
        return false;
    }
}

void ShowCredits()
{
    var credits=creditService.GetCredits();
    if (credits.Count==0)
    {
        Console.WriteLine("Kredi Bulunamadı.");
    }
    else
    {
        foreach (var credit in credits)
        {
            Console.WriteLine("--------------------------------------------" + "\n" +
                "Kalan Borç:" + credit.RemainingTotalCreditMoney +"\n"+
                "Kalan Taksit:" + credit.CreditCountRemaining + "\n" +
                "Kalan Bu Aylık Ödeme Tutarı:" + credit.RemainingCreditMoneyThisMonth + "\n" +
                "Kredinin Tam Tutarı:" + credit.TotalCreditMoney + "\n" +
                "Kredinin Tam Taksit Sayısı:" + credit.CreditAllCount);
        }
        Console.WriteLine("--------------------------------------------");
    }
}