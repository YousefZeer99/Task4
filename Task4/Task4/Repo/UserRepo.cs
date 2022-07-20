using Task4.Models;

namespace Task4.Repo
{
    public class UserRepo
    {
        static List<User> users { get; set; }

        static UserRepo()
        {
            users = new List<User>()
            {
                new User(){id = 1 , Fname = "Yousef" , Lname = "Al Zeer" },
                new User(){id = 2 , Fname = "Thabet" , Lname = "Waleed" },
                new User(){id = 3 , Fname = "Maya" , Lname = "Awad" },
                new User(){id = 4 , Fname = "Jadon" , Lname = "Sancho" },
                new User(){id = 5 , Fname = "Wayne" , Lname = "Rooney" }


            };
        }

        public static List<User> GetAll()
        {
            return users;

        }

        public static User Get(int id)
        {
            return users.FirstOrDefault(x => x.id == id);
        }

        public static void Delete(int id)
        {
            var user = Get(id);
            if (user != null)
                users.Remove(user);


        }

        public static void Add(User user)
        {
            users.Add(user);
        }

        public static void Update(User user)
        {
            var index = users.FindIndex(e => e.id == user.id);
            if (index == -1) return;
            users[index] = user;
        }
    }
}
