using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {

        static void PrintRandomNumbers(int x)
        {
            Random rnd = new Random(x);
            for (int i = 0; i < 12; i++)
            {
                Console.Write(rnd.Next(0, 100) + " ");
            }
            Console.WriteLine();
        }





        //             0123456
        // Alphabet = "abcdefg";
        // Alphabet.Length = 7

        // Length = 10
        static string GenRandomString(string Alphabet, int Length) 
        {
            Random rnd = new Random();         
            StringBuilder sb = new StringBuilder(Length);
            int Position = 0;                             
            for (int i = 0; i < Length; i++)
            {
                Position = rnd.Next(0, Alphabet.Length);
                sb.Append(Alphabet[Position]);             
            }
            return sb.ToString();
        }


        static string GenerateRandomStringFromArray(string[] words, Random rnd)  
        {           
            int position = rnd.Next(0, words.Length);
            return words[position];
        }

        static string GenerateRandomMaleName(Random rnd)
        {
            string[] names = {"Petr", "Nick", "Vasiliy" , "Konstantin" , "Martin", "Yuriy"};
            return GenerateRandomStringFromArray(names,rnd);
        }

        static string GenerateRandomFemaleName(Random rnd)
        {
            string[] names = {"Katya", "Maria", "Julia" };
            return GenerateRandomStringFromArray(names,rnd);
        }

        static string GenerateRandomMaleSurname(Random rnd)
        {
            string[] surnames = { "Petrov", "Sidorov", "Vasin", "Parov" };
            return GenerateRandomStringFromArray(surnames,rnd);
        }

        static string GenerateRandomFemaleSurname(Random rnd)
        {
            string[] surnames = { "Petrova", "Sidorova", "Vasina", "Parova" };
            return GenerateRandomStringFromArray(surnames,rnd);
        }
        static string GenerateRandomMalePatronimic(Random rnd)
        {
            string[] patronimic = { "Petrovitch", "Sergeevitch", "Vasilyevitch", "Maximovitch" };
            return GenerateRandomStringFromArray(patronimic, rnd);
        }

        static string GenerateRandomFemalePatronimic(Random rnd)
        {
            string[] patronimic = { "Petrovna", "Sidorovna", "Vasilyevna", "Semenovna" };
            return GenerateRandomStringFromArray(patronimic, rnd);
        }


        static string GenerateRandomWorkDescription(Random rnd)
        {
            string[] workDescriptions = { "Варит пиво", "Сушит рыбу", "Уборщик мусора", "Дегустатор" };
            return GenerateRandomStringFromArray(workDescriptions, rnd);
        }


        static Genre GenerateRandomGenre(Random rnd)
        {
            Genre[] genres = { Genre.FEMALE, Genre.MALE };
            int position = rnd.Next(0, genres.Length);
            return genres[position];
        }


        static Nationality GenerateRandomNationality(Random rnd)
        {
            string[] nats = Enum.GetNames(typeof(Nationality));// Enum.GetNames - делает массив строк из enum
            int count = nats.Length;
            int intNationality = rnd.Next(0, count);
            // Nationality.British хранится в памяти как  4
            return (Nationality)intNationality;
        }

        


        static void Main(string[] args)
        {
            /*Human human = new Human();
            Console.WriteLine(human);
            Console.WriteLine(human.ToString());
            Console.WriteLine(human.genre);
            Console.WriteLine(human.nationality);
            Console.WriteLine(human.Name); //поле: чтение
            human.Name = "Вася";           //поле: запись
            Console.WriteLine(human.Name); 
            Console.WriteLine(human.getName());*/

            try
            {
                //класс абстрактный - нет возможности создать его экземпляр
                //Human human = new Human("Марко", "Поло", "Иммануилович", new DateTime(1775, 10, 25), Genre.MALE, Nationality.English);
                //Employee employee = new Employee();
                //Console.WriteLine(employee);

                /*Tutor tutor = new Tutor();
                Console.WriteLine(tutor);
                tutor.Show();

                Tutor tutor_two = new Tutor("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English, 
                                        EducationLevel.Higher, 3500f, TutorSpeciality.Biologist);

                Console.WriteLine(tutor_two);


                Worker worker = new Worker("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English,
                                        EducationLevel.Higher, 3500f, "Колоть дрова");

                if (!worker.IsWorking)
                {
                    worker.NextTask("Выпить кофе");
                }
                worker.StopWorking();
                worker.NextTask("Покурить");
                Console.WriteLine(worker.Work());
                worker.StopWorking();
                worker.NextTask("Колоть дрова");
                Console.WriteLine(worker.Work());

                
                Manager manager = new Manager();
                manager.addWorker(worker);
                */
                //Random random = new Random();
                //ListOfWorkers listOfWorkers = new ListOfWorkers();
                //for (int i = 0; i < 25; i++)
                //{
                //    listOfWorkers.AddWorker(
                //        new Worker (
                //            "worker_" + i,
                //            "tested",
                //            "tested",
                //            DateTime.Now,
                //            Genre.UNDEFINED,
                //            Nationality.Argentine,
                //            EducationLevel.Higher,
                //            random.Next(2500, 5500)
                //            ,
                //            "чтото делает и слава богу")
                //    );
                //}

                /**for (int i = listOfWorkers.Count - 1; i >= 0; i--)
                {
                    listOfWorkers.RemoveWorker(listOfWorkers.Workers[i]);
                }

                for (int i = 0; i < 25; i++)
                {
                    listOfWorkers.RemoveWorker(listOfWorkers.Workers[0]);
                }

                Console.WriteLine(listOfWorkers);

                Console.WriteLine(listOfWorkers.Count);
                Console.WriteLine(listOfWorkers.Workers.Length);


                Point2D point2D = new Point2D();
                Console.WriteLine(++point2D);
                    //point2D++;
                    //++point2D;
                Console.WriteLine(point2D);
                Console.WriteLine(-point2D);
                Console.WriteLine(point2D);

                Console.WriteLine(point2D + new Point2D(15,45));

                Console.WriteLine(point2D + 15);
                Console.WriteLine(45 + point2D);

                Point2D point2D1 = new Point2D(15,15);
                Point2D point2D2 = new Point2D(15,10);

                Console.WriteLine(point2D1);
                Console.WriteLine(point2D2);

                Console.WriteLine(point2D1.Equals(point2D2));


                if (!point2D1)
                {
                    Console.WriteLine("точка в положительном пространстве");
                }
                else
                {
                    Console.WriteLine("точка в отрицательном пространстве");
                }


                listOfWorkers[5] = new Worker();
                Console.WriteLine(((Worker)listOfWorkers[5]).Name); //по индексу


                Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[5]]).Name); //через ссылку на обьект
                listOfWorkers[listOfWorkers.Workers[6]] = new Worker();
                Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[6]]));
                */




                //int[] arr = new int[25];
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    arr[i] = random.Next(0, 10);
                //    Console.Write(arr[i] + " ");
                //}
                //Console.WriteLine();

                //foreach (var item in arr)
                //{
                //    Console.Write(item + " ");
                //}
                //Console.WriteLine();

                /**IEnumerable возвращает GetEnumerator()
                 
                    IEnumerator 
                        : MoveNext()
                        : object Current {get; }
                        : void Reset()
                 */

                //Console.WriteLine("Через IEnumerator: ");
                //IEnumerator ieArr = arr.GetEnumerator();
                //while (ieArr.MoveNext())
                //{
                //    int item = (int)ieArr.Current;
                //    Console.Write(item + " ");
                //}
                //ieArr.Reset();


                //foreach (Worker item in listOfWorkers)
                //{
                //    Console.WriteLine(item);
                //}


                //Worker worker_1 =
                //    new Worker("Макс", "", "", DateTime.Now, Genre.MALE, Nationality.Argentine, EducationLevel.Higher, 2500f, "работаю");

                //Worker worker_2 = worker_1; //ссылка

                //worker_2.Name = "Максимилиан";
                //Console.WriteLine(worker_1.Name);
                //Console.WriteLine(worker_2.Name);


                ///*ICloneable - чтобы обьект смог создавать копию самого себя*/

                //Worker worker_3 = (Worker)worker_1.Clone();
                //worker_3.Name = "Новое имяяяя";
                //Console.WriteLine(worker_3);


                //Worker worker_4 = (Worker)worker_3.Clone(CloneWorkerMethod.Complete);
                //worker_4.Name = "Маклауд";

                //Console.WriteLine(worker_4.Name);
                //Console.WriteLine(worker_3.Name);


                /*задействуется стандартная сортировка - default - по возрастанию
                    int string
                    IComparable

                    int CompareTo(Object 0){
                        < 0 текущее знаяение идет первым - левее от сравниваемого
                        > 0 текущее значение идет вторым - после сравниваемого
                        == 0 значит что значения равны
                    }
                 */


                /*используется стандартная сортировка - но переопределенная нами -- наоборот - по ниспаданию*/
                /*Array.Sort(listOfWorkers.Workers);
                foreach (Worker worker in listOfWorkers.Workers)
                {
                    Console.WriteLine(worker);
                }*/


                /**
                ListOfWorkers listOfWorkers = new ListOfWorkers();  
                string name = "Petr";
                string surname = "Petrov";
                string patronimic = "Petrovitch";
                float salary = 2500.00f;
                string workDescription = "Варить пиво";                
                Worker worker1 = new Worker(
                        name,
                        surname,
                        patronimic,
                        DateTime.Now,
                        Genre.UNDEFINED,
                        Nationality.Argentine,
                        EducationLevel.Higher,
                        salary,
                        workDescription);


                name = GenerateRandomFemaleName();
                surname = "Vasin";
                patronimic = "Vasilevitch";
                salary = 1600.00f;
                workDescription = "Сушить рыбу";
                Worker worker2 = new Worker(
                      name,
                      surname,
                      patronimic,
                      DateTime.Now,
                      Genre.UNDEFINED,
                      Nationality.Argentine,
                      EducationLevel.Higher,
                      salary,
                      workDescription);


                listOfWorkers.AddWorker(worker1);
                listOfWorkers.AddWorker(worker2);

                */



                ListOfWorkers listOfWorkers = new ListOfWorkers();
                string name;
                string surname;
                string patronimic;
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {                  
                    Genre genre = GenerateRandomGenre(rnd);

                    if (genre.Equals(Genre.FEMALE))
                    {
                        name = GenerateRandomFemaleName(rnd);
                        surname = GenerateRandomFemaleSurname(rnd);
                        patronimic = GenerateRandomFemalePatronimic(rnd);
                    }
                    else 
                    {
                        name = GenerateRandomMaleName(rnd);
                        surname = GenerateRandomMaleSurname(rnd);
                        patronimic = GenerateRandomMalePatronimic(rnd);
                    }
                    Nationality nationality = GenerateRandomNationality(rnd);

                    int year = rnd.Next(1960, 2000);
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, 29);
                    DateTime dateTime = new DateTime(year, month, day);
                    float salary = rnd.Next(10000, 50000);
                    string workDescription = GenerateRandomWorkDescription(rnd);
                    Worker worker1 = new Worker(
                            name,
                            surname,
                            patronimic,
                            dateTime,
                            genre,
                            nationality,
                            EducationLevel.Higher,
                            salary,
                            workDescription);
                    listOfWorkers.AddWorker(worker1);






                }


                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("сортировка по имени по убыванию: ");//Yuriy - first name

                //IWorker[] tmp = listOfWorkers.Workers;
                //Array.Sort(tmp, new WorkerNameDescComparer());

                //foreach (Worker worker in tmp)
                //{
                //    Console.WriteLine(worker);
                //}
                //Console.ResetColor();






                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("сортировка по зарплате по убыванию: ");// Biggest number is first

                //IWorker[] tmp = listOfWorkers.Workers;
                //Array.Sort(tmp, new WorkerSalaryDescComparer());

                //foreach (Worker worker in tmp)
                //{
                //    Console.WriteLine(worker);
                //}
                //Console.ResetColor();

                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("сортировка по зарплате по возрастанию: ");// Smallest number is first

                //IWorker[] tmp = listOfWorkers.Workers;
                //Array.Sort(tmp, new WorkerSalaryAscComparer());

                //foreach (Worker worker in tmp)
                //{
                //    Console.WriteLine(worker);
                //}
                //Console.ResetColor();

                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("сортировка по Дню рождения по возрастанию: ");

                //IWorker[] tmp = listOfWorkers.Workers;
                //Array.Sort(tmp, new WorkerBirthDateAscComparer());

                //foreach (Worker worker in tmp)
                //{
                //    Console.WriteLine(worker);
                //}
                //Console.ResetColor();

                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("сортировка по Дню рождения по убыванию: ");

                //IWorker[] tmp = listOfWorkers.Workers;
                //Array.Sort(tmp, new WorkerBirthDateDescComparer());

                //foreach (Worker worker in tmp)
                //{
                //    Console.WriteLine(worker);
                //}
                //Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("сортировка по Дню рождения по возрастанию: ");

                IWorker[] tmp = listOfWorkers.Workers;
                Array.Sort(tmp, new WorkerBirthDateAscComparer());

                foreach (Worker worker in tmp)
                {
                    Console.WriteLine(worker);
                }
                Console.ResetColor();



                //Console.WriteLine((int)'a');
                //Console.WriteLine((int)'b');


                // 10 < 15  по возрастанию
                // "abc" < "zzz" по возрастанию
                //Console.WriteLine("abc".CompareTo("zz")); // -1 - если первый аргумент меньше второго 
                //Console.WriteLine(10.CompareTo(15));//-1



                /** cast
                // Worker w = new Worker();
                //object h = w;
                //Worker workerCastFromH = (Worker)h;
                //Console.WriteLine(workerCastFromH.Work());
                */



            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Я ошибка, но программа не вылетела :)");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            Console.WriteLine("Я программа и я все одно работаю :)");
            Console.ReadKey();
        }
    }

}
