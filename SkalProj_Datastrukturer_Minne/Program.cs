using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        /// 


        static void Main()
        {
            #region remove Hårdkodat
            // theList = new List<string>();
            //ListHandler handler = new ListHandler();
            //string addItems = "Kalle";
            //string addItems2 = "Greta";
            //string addItems3 = "Stina";
            //string addItems4 = "Olle";
            //string addItems5 = "Reserv";

            //var theListH = handler.AddListItem(addItems);
            //theListH = handler.AddListItem(addItems2);
            //theListH = handler.AddListItem(addItems3);
            //theListH = handler.AddListItem(addItems4);
            //theListH = handler.AddListItem(addItems5);
            //var node1 = new Node<int>();
            //node1.Value = 10;
            //var node2 = new Node<string>();
            //node2.Value = "heja heja";

            //var node3 = new Node<object>();
            //Console.WriteLine(node1);
            //Console.WriteLine(node2);
            //Console.WriteLine(node3); 

            //GenericList<int> testList = new GenericList<int>();
            //testList.AddFirstNode(1);
            //testList.AddFirstNode(2);
            //testList.AddFirstNode(3);

            //var node = testList.First;

            //for (int i = 0; i < testList.CountNode; i++)
            //{
            //    Console.WriteLine(testList[i]);
            //}

            //while(node != null)
            //{
            //    Console.WriteLine(node);
            //    node = node.Next;
            //}



            //var lItems = new List<ListItems>
            //{
            //    new ListItems("Kalle"),
            //    new ListItems("Greta"),
            //    new ListItems("Stina"),
            //    new ListItems("Olle"),
            //};

            //foreach (var item in lItems)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            //ListHandler handler = new ListHandler();
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            bool run = true;

            List<string> theList = new List<string>();

            while (run)
            {
                string input = Console.ReadLine();
                if (input == null)
                {
                    input = "0";
                }
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {

                    case '+':
                        {

                            theList.Add(value);

                            Console.WriteLine("Count: " + theList.Count + ", Capacity: " + theList.Capacity);

                            break;
                        }
                    case '-':
                        {
                            theList.Remove(value);
                            Console.WriteLine("Count: " + theList.Count + ", Capacity: " + theList.Capacity);

                            break;
                        }
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("You can only use + or - as the first caracter");
                            run = false;
                            break;
                        }
                }
            }

        }


        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            bool run = true;


            Queue queueList = new Queue();

            while (run)
            {
                #region remove


                /*
                 GenericList<string> theQueueList = new GenericList<string>();
                  List<string> theList = new List<string>();
                  queueList.Enqueue("Kalle");
                 Console.WriteLine("Kalle ställer sig i kön");
                 Console.WriteLine("Antal i kö {0}" , queueList.Count);

                 queueList.Enqueue("Greta");
                 Console.WriteLine("Greta ställer sig i kön");
                 Console.WriteLine("Antal i kö {0}", queueList.Count);

                 queueList.Dequeue();
                 Console.WriteLine("Kalle Är klar och lämnar sin plats i kön");
                 Console.WriteLine("Antal i kö {0}", queueList.Count);

                 queueList.Enqueue("Stina");
                 Console.WriteLine("Stina ställer sig i kön");
                 Console.WriteLine("Antal i kö {0}", queueList.Count);

                 queueList.Dequeue();
                 Console.WriteLine("Greta är klar och lämnar sin plats i kön");
                 Console.WriteLine("Antal i kö {0}", queueList.Count);

                 queueList.Enqueue("Olle");
                 Console.WriteLine("Olle ställer sig i kön");
                 Console.WriteLine("Antal i kö {0}", queueList.Count);
                */
                #endregion
                string input = Console.ReadLine();

                if (input == "")
                {
                    input = "0";
                }
                char nav = input[0];

                string value = input.Substring(1);
                //TestQueue(nav, value, queueList);

                #region switch 
                switch (nav)
                {


                    case '+':
                        {
                            TestQueue(nav, value, queueList);
                            /*queueList.Enqueue(value);
                            Console.WriteLine("{0} Ställde sig i kön. Antal i kö {1}", value, queueList.Count);
                            */
                            break;
                        }
                    case '-':
                        {
                            TestQueue(nav, value, queueList);
                            /*
                            queueList.Dequeue();
                            Console.WriteLine("{0} LÄmnade kön. Antal i kö {1}", value, queueList.Count);
                            */
                            break;
                        }
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("You can only use + or - as the first caracter");
                            run = false;
                            break;
                        }
                }
                #endregion

                #region tabort 
                //theQueueList.AddFirstNode("+Kalle");
                //theQueueList.AddFirstNode("+Greta");
                //theQueueList.AddFirstNode("-Kalle");
                //theQueueList.AddFirstNode("+Stina");
                //theQueueList.AddFirstNode("-Greta");
                //theQueueList.AddFirstNode("+Olle");


                //var node = theQueueList.First;


                //for (int i = 0; i < theQueueList.CountNode; i++)
                //{
                //    if (i == 0)
                //    {
                //        theQueueList.RemoveFirst(theQueueList[i]);
                //    }

                //    Console.WriteLine(theQueueList[i]);
                //}
                //run = false;



                #endregion
            }
        }

        private static void TestQueue(char nav, string value, Queue queueList)
        {
            if (nav.Equals('+'))
            {
                queueList.Enqueue(value);
                Console.WriteLine("{0} Ställde sig i kön. Antal i kö {1}", value, queueList.Count);
            }
            else if (nav.Equals('-'))
            {
                queueList.Dequeue();
                Console.WriteLine("{0} LÄmnade kön. Antal i kö {1}", value, queueList.Count);
            }
            else if (nav.Equals('0'))
            {
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            bool run = true;
            Stack stackList = new Stack();
            Stack<string> reverseStackList = new Stack<string>();

            while (run)
            {

                string input = Console.ReadLine();

                if (input == "")
                {
                    input = "0";
                }
                char nav = input[0];

                string value = input.Substring(1);

                #region switch 
                switch (nav)
                {

                    case '+':
                        {
                            //stackList.Push(value);
                            //Console.WriteLine("{0} Ställde sig i kön. Antal i kö {1}", value, stackList.Count);

                            //utan stack-ojektet
                            int noChar = value.Length;
                            char[] revString = value.ToCharArray();
                            ReverseText(revString);
                            Console.WriteLine(string.Join("", revString));

                            //revers text med stack
                            StringBuilder strB = new StringBuilder(value);

                            stackList = new Stack(noChar);

                            for (int i = 0; i < noChar; i++)
                            {
                                stackList.Push(value[i]);
                            }

                            for (int i = 0; i < noChar; i++)
                            {
                                char ch = (char)stackList.Pop();
                                strB[i] = ch;
                            }
                            Console.WriteLine("Via stringbuilder och stack: " + strB);



                            #region more to remove
                            //Console.WriteLine("in the PUSH section");

                            //Console.WriteLine("\n********* START STACKLISTA ********");
                            //foreach (var item in stackList)
                            //{
                            //    Console.WriteLine(item);
                            //}
                            //Console.WriteLine("***** END STACKLISTA Section ******\n");

                            //reverseList = new Stack(stackList.ToArray());
                            //Console.WriteLine("\n***** START REVERSE LISTA Section ******");

                            //foreach (string revitem in reverseList)
                            //{
                            //    Console.WriteLine(revitem);
                            //}
                            //Console.WriteLine("***** END REVERSE LISTA Section ******\n");
                            #endregion
                            #region remove
                            /*
                           // reverseStackList.Push(value);
                            //skapar en string Array
                            string[] stackArryay = new string[stackList.Count];

                            //kopierar till värdena till arrayen
                            stackList.CopyTo(stackArryay, 0);

                            Console.WriteLine("\nREVERSE LISTA");
                            foreach (var arrayitem in stackArryay)
                            {
                                Console.WriteLine(arrayitem);
                            }
                            */
                            #endregion
                            break;
                        }
                    case '-':
                        {

                            stackList.Pop();
                            #region
                            //reverseList = new Stack(stackList.ToArray());

                            //reverseList.Pop();
                            //Console.WriteLine("\n***** START POP Section ******");
                            //Console.WriteLine("{0} Lämnade kön. Antal i kö {1}", value, reverseList.Count);
                            //Console.WriteLine("In the POP section");
                            //foreach (var item in reverseList)
                            //{
                            //    Console.WriteLine(item);
                            //    stackList.Push(item);
                            //}
                            //Console.WriteLine("***** END POP Section ******\n");

                            #endregion

                            #region remove
                            /*
                            Stack reverseList = new Stack(stackList.ToArray());
                            reverseList.Pop();
                            Console.WriteLine("\n ******* REVERSE LISTA 2 **********");
                            foreach (string revitem in reverseList)
                            {
                                Console.WriteLine(revitem);
                            }*/
                            #endregion
                            break;
                        }
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("You can only use + or - as the first caracter");
                            run = false;
                            break;
                        }
                }
                #endregion
            }

        }

        private static void ReverseText(char[] revString)
        {
            int noChar = revString.Length;
            //Stack reverseText = new Stack(noChar);
            for (int i = 0; i < noChar / 2; i++)
            {
                revText(revString, i, noChar - i - 1);
                //reverseText.Push(revString[i]);
            }


        }

        static void revText(char[] revString, int index1, int index2)
        {
            char tempString = revString[index1];
            revString[index1] = revString[index2];
            revString[index2] = tempString;

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            while (true)
            {
                #region hårdkodat sträng
                //hårdkodad array för tecken som ska vara korrekta
                //
                //char[] checkPar1 = { '(', ')', '{', '}', '[', ']' };

                //if (CorrectParantheses(checkPar1))
                //{
                //    Console.WriteLine("Hårdkodad correct ");
                //}
                //else
                //{
                //    Console.WriteLine(" Hårdkodad incorrect");
                //}
                #endregion

                string input = Console.ReadLine();
                if (input == "")
                {
                    input = "0";
                }
                char nav = input[0];
                string value = input.Substring(1);
                StringBuilder strB = new StringBuilder(value);
                Console.WriteLine("stringbuilder " + strB);
                #region switch 
                switch (nav)
                {
                    case '+':
                        {
                            char[] checkString = value.ToCharArray();
                            //CheckPairInString(checkString);

                            if (CorrectParantheses(checkString))
                            {
                                Console.WriteLine("Parantheses are correct ");
                            }
                            else
                            {
                                Console.WriteLine("Parantheses are incorrect");
                            }

                            break;
                        }
                    case '-':
                        {
                            break;
                        }
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("You can only use + or - as the first caracter");
                            break;
                        }
                }
                #endregion
            }
        }

        //används inte, testgrej
        private static void CheckPairInString(char[] checkString)
        {
            for (int i = 0; i < checkString.Length; i++)
            {
                Console.WriteLine(checkString[i]);
            }
        }

        static bool CorrectParantheses(char[] checkPar1)
        {
            //skapa en tom stack, som ska hålla chars av (){}[] - i rätt matchning
            Stack<char> cString = new Stack<char>();

            for (int i = 0; i < checkPar1.Length; i++)
            {
                //om det är en början-parantes
                if (checkPar1[i] == '(' || checkPar1[i] == '{' || checkPar1[i] == '[')
                {
                    //lägg till stack
                    cString.Push(checkPar1[i]);
                }
                //om det är en slut-parantes, utan matchande början parantes
                if (checkPar1[i] == ')' || checkPar1[i] == '}' || checkPar1[i] == ']')
                {
                    //bara en slut parantes - incorrect
                    if (cString.Count == 0)
                    {
                        return false;
                    }
                    //om det inte finns en början-parantes - incorrect
                    //ta bort från stacken isf
                    else if (!IsAMatch(cString.Pop(), checkPar1[i]))
                    {
                        return false;
                    }
                }
            }
            if (cString.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsAMatch(char v1, char v2)
        {

            if (v1 == '(' && v2 == ')')
            {
                return true;
            }
            else if (v1 == '{' && v2 == '}')
            {
                return true;
            }
            else if (v1 == '[' && v2 == ']')
            {
                return true;
            }
            else
                return false;
        }
    }
}

