using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mvc_project
{
    class Program
    {
        static void Main(string[] args)
        {
            User model = retriveFirstUserFromDatabase();

            UserView view = new UserView();

            UserController controller = new UserController(model, view);

            controller.updateView();

            controller.setUserName("Valentyn");

            controller.updateView();

            User user1 = new User("Oleg", "oleg1337@gmail.com", 10008);

            PurchaseCollection collection1 = new PurchaseCollection();
            collection1[0] = new Purchase.Builder()
                .withKind("Percent Bet")
                .withName("Football")
                .withTeam("Real Madrid")
                .withDate(DateTime.Now)
                .withAmount(2500)
                .build();
            collection1[1] = new Purchase.Builder()
                .withKind("Percent Bet")
                .withName("Football")
                .withTeam("Barcelona")
                .withDate(DateTime.Now)
                .withAmount(500)
                .build();

            model.Purchases = collection1;
            model.getAllActivePurchases();

            PurchaseCollection collection2 = new PurchaseCollection();
            collection2[0] = new Purchase.Builder()
                .withKind("Percent Bet")
                .withName("Chess")
                .withTeam("Kasparov`s team")
                .withDate(DateTime.Now)
                .withAmount(800)
                .build();
            collection2[1] = new Purchase.Builder()
                .withKind("Percent Bet")
                .withName("Football")
                .withTeam("Real Madrid")
                .withDate(DateTime.Now)
                .withAmount(2500)
                .build();
            collection2[2] = new Purchase.Builder()
                .withKind("Percent Bet")
                .withName("Basketball")
                .withTeam("Orlando")
                .withDate(DateTime.Now)
                .withAmount(1800)
                .build();

            user1.Purchases = collection2;
            user1.getAllActivePurchases();

            model.sendMessage("Hi Ivan! It`s a nice day to make bets!");
            Thread.Sleep(2000);
            user1.sendMessage("Hello! Valentyn! I agree with you!");
            Thread.Sleep(1000);
            model.sendMessage("I made one on football...");
            Thread.Sleep(2000);
            user1.sendMessage("Nice! Good luck :D\n");

            UserCollection e = new UserCollection();
            e.Attach(model);
            e.Attach(user1);

            Console.WriteLine("Our site is giving the bonus to a total amount of cash on the balance...\n");
            e.Accept(new TotalCashVisitor());

            Console.ReadLine();
        }

        private static User retriveFirstUserFromDatabase()
        {
            User user = new User();
            user.Name = "Valentyno2ke";
            user.Email = "valentyn1998@gmail.com";
            Balance balance = Balance.getInstance(1200);
            user.Balance = balance.Amount;
            return user;
        }
    }
}
