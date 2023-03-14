using System;

namespace deu_latest_game
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //first we make 3 arrays to create our game.
                char[] A1 = new char[15];
                char[] A2 = new char[15];
                char[] A3 = new char[15];

                for (int i = 0; i < 15; i++)// at first our arrays are empty so their character are ' '.
                {
                    A1[i] = ' ';
                    A2[i] = ' ';
                    A3[i] = ' ';
                }
                //Then we create two random numbers.
                Random rnd = new Random();
                int random_array = rnd.Next(1, 4);// this is for choosing a random array.
                int random_index = rnd.Next(0, 3);// this is for choosing a random letter.
                static char get_char(int random_index)// this function changes the random integer into one of the letters D,E or U.
                {
                    if (random_index == 0)
                    {
                        return 'D';
                    }
                    else if (random_index == 1)
                    {
                        return 'E';
                    }
                    else if (random_index == 2)
                    {
                        return 'U';
                    }
                    else
                    {
                        return 'X';
                    }
                }
                //now we set our counters.
                int game_counter = 0;
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                int score_of_player_1 = 120;
                int score_of_player_2 = 120;
                bool is_game_over = false;
                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("WELCOME THE DEU GAME!");
                //Console.WriteLine("ARE YOU LUCKY ENOUGH TO GET THE DEU BEFORE YOUR COMPONENT? LET'S SEE!");
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("...press enter to play the game...");

                //Console.ReadLine();
                //Console.Clear();
                //Console.ForegroundColor = ConsoleColor.White;
                //I commented out these lines because that enter might be an input.
                do
                {
                    random_array = rnd.Next(1, 4);//first we pick a random array.


                    //after that we pick a random letter to place.
                    if (random_array == 1)
                    {
                        if (count1 < 14)
                        {
                            random_index = rnd.Next(0, 3);
                            A1[count1] = get_char(random_index);

                        }

                    }
                    else if (random_array == 2)
                    {
                        if (count2 < 14)
                        {
                            random_index = rnd.Next(0, 3);
                            A2[count2] = get_char(random_index);

                        }
                    }
                    else if (random_array == 3)
                    {
                        if (count3 < 14)
                        {
                            random_index = rnd.Next(0, 3);
                            A3[count3] = get_char(random_index);

                        }
                    }
                    //now we are printing our latest arrays.
                    Console.Write("A1 ");
                    for (int i = 0; i < 15; i++)
                    {
                        Console.Write(A1[i]);
                    }
                    Console.WriteLine();
                    Console.Write("A2 ");
                    for (int i = 0; i < 15; i++)
                    {
                        Console.Write(A2[i]);
                    }
                    Console.WriteLine();
                    Console.Write("A3 ");
                    for (int i = 0; i < 15; i++)
                    {
                        Console.Write(A3[i]);
                    }
                    Console.WriteLine();

                    string winner_player(int game_counter)//this function decides who the winner is.
                                                          //If the number of the games we played is even that means it was player1's turn.
                                                          //If the number of the games we played is odd that means it was player2's turn.
                    {
                        if (game_counter % 2 == 0)
                        { return "Winner is : Player 1  CONGRATULATIONS!"; }
                        else if (game_counter % 2 == 1)
                        { return "Winner is : Player 2  CONGRATULATIONS"; }
                        else
                            return "error";
                    }

                    if ((count3 >= 14) && (count2 >= 14) && (count1 >= 14))//If the game ends with no DEU sequence then it's a tie.
                    {
                        is_game_over = true;
                        Console.WriteLine("It's a tie.No winner.");
                        Console.ReadLine();

                    }


                    //now we check all the possible situations for a straight or reversed DEU sequence
                    //which can be placed horizontally,vertically or diagonally.
                    if ((A1[count1] == 'U') && (A1[Math.Abs(count1 - 1)] == 'E') && (A1[Math.Abs(count1 - 2)] == 'D'))
                    {
                        if ((count1 - 1 < 0) || (count1 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            Console.WriteLine("There's a straight DEU on A1!");
                            is_game_over = true;
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A1[count1] == 'D') && (A1[Math.Abs(count1 - 1)] == 'E') && (A1[Math.Abs(count1 - 2)] == 'U'))
                    {
                        if ((count1 - 1 < 0) || (count1 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            Console.WriteLine("There's a reversed DEU on A1!");
                            is_game_over = true;
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A2[count2] == 'U') && (A2[Math.Abs(count2 - 1)] == 'E') && (A2[Math.Abs(count2 - 2)] == 'D'))
                    {
                        if ((count2 - 1 < 0) || (count2 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            Console.WriteLine("There's a straight DEU on A2!");
                            is_game_over = true;
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A2[count2] == 'D') && (A2[Math.Abs(count2 - 1)] == 'E') && (A2[Math.Abs(count2 - 2)] == 'U'))
                    {
                        if ((count2 - 1 < 0) || (count2 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            Console.WriteLine("There's a reversed DEU on A2!");
                            is_game_over = true;
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A3[count3] == 'U') && (A3[Math.Abs(count3 - 1)] == 'E') && (A3[Math.Abs(count3 - 2)] == 'D'))
                    {
                        if ((count3 - 1 < 0) || (count3 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            is_game_over = true;
                            Console.WriteLine("There's a straight DEU on A3!");
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A3[count3] == 'D') && (A3[Math.Abs(count3 - 1)] == 'E') && (A3[Math.Abs(count3 - 2)] == 'U'))
                    {
                        if ((count3 - 1 < 0) || (count3 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            is_game_over = true;
                            Console.WriteLine("There's a reversed DEU on A3!");
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A1[count1] == 'D') && (A2[count1] == 'E') && (A3[count1] == 'U'))
                    {
                        is_game_over = true;
                        Console.WriteLine("There's a vertical DEU!");
                        Console.WriteLine(winner_player(game_counter));
                        Console.ReadLine();
                    }
                    if ((A1[count2] == 'D') && (A2[count2] == 'E') && (A3[count2] == 'U'))
                    {
                        is_game_over = true;
                        Console.WriteLine("There's a vertical DEU!");
                        Console.WriteLine(winner_player(game_counter));
                        Console.ReadLine();
                    }
                    if ((A1[count3] == 'D') && (A2[count3] == 'E') && (A3[count3] == 'U'))
                    {
                        is_game_over = true;
                        Console.WriteLine("There's a vertical DEU!");
                        Console.WriteLine(winner_player(game_counter));
                        Console.ReadLine();
                    }

                    if ((A1[count1] == 'U') && (A2[count1] == 'E') && (A3[count1] == 'D'))
                    {
                        is_game_over = true;
                        Console.WriteLine("There's a vertical DEU, caution: it's reversed!");
                        Console.WriteLine(winner_player(game_counter));
                        Console.ReadLine();
                    }
                    if ((A1[count2] == 'U') && (A2[count2] == 'E') && (A3[count2] == 'D'))
                    {
                        is_game_over = true;
                        Console.WriteLine("There's a vertical DEU, caution: it's reversed!");
                        Console.WriteLine(winner_player(game_counter));
                        Console.ReadLine();
                    }
                    if ((A1[count3] == 'U') && (A2[count3] == 'E') && (A3[count3] == 'D'))
                    {
                        is_game_over = true;
                        Console.WriteLine("There's a vertical DEU, caution: it's reversed!");
                        Console.WriteLine(winner_player(game_counter));
                        Console.ReadLine();
                    }

                    if ((A1[count1] == 'D') && (A2[Math.Abs(count1 - 1)] == 'E') && (A3[Math.Abs(count1 - 2)] == 'U'))
                    {
                        if ((count1 - 1 < 0) || (count1 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            is_game_over = true;
                            Console.WriteLine("There's a diagonal DEU!");
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A1[count1] == 'U') && (A2[Math.Abs(count1 - 1)] == 'E') && (A3[Math.Abs(count1 - 2)] == 'D'))
                    {
                        if ((count1 - 1 < 0) || (count1 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            is_game_over = true;
                            Console.WriteLine("There's a diagonal DEU, caution: it's reversed!");
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }
                    if ((A1[Math.Abs(count2 - 1)] == 'D') && (A2[Math.Abs(count2)] == 'E') && (A3[Math.Abs(count2 + 1)] == 'U'))
                    {
                        if ((count2 - 1 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            is_game_over = true;
                            Console.WriteLine("There's a diagonal DEU!");
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }
                    if ((A1[Math.Abs(count2 - 1)] == 'U') && (A2[Math.Abs(count2)] == 'E') && (A3[Math.Abs(count2 + 1)] == 'D'))
                    {
                        if ((count2 - 1 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            is_game_over = true;
                            Console.WriteLine("There's a diagonal DEU, caution: it's reversed!");
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A1[Math.Abs(count3 - 2)] == 'D') && (A2[Math.Abs(count3 - 1)] == 'E') && (A3[count3] == 'U'))
                    {
                        if ((count3 - 1 < 0) || (count3 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            is_game_over = true;
                            Console.WriteLine("There's a diagonal DEU!");
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }

                    if ((A1[Math.Abs(count3 - 2)] == 'U') && (A2[Math.Abs(count3 - 1)] == 'E') && (A3[count3] == 'D'))
                    {
                        if ((count3 - 1 < 0) || (count3 - 2 < 0))
                        {
                            is_game_over = false;
                        }
                        else
                        {
                            is_game_over = true;
                            Console.WriteLine("There's a diagonal DEU, caution: it's reversed!");
                            Console.WriteLine(winner_player(game_counter));
                            Console.ReadLine();
                        }
                    }
                    //we increase our array counters by 1 if that array was the one which got a new letter.So next turn other letter will be placed next to old one.
                    if (random_array == 1)
                    {
                        if (count1 < 14)
                        {

                            count1++;
                        }

                    }
                    else if (random_array == 2)
                    {
                        if (count2 < 14)
                        {

                            count2++;
                        }
                    }
                    else if (random_array == 3)
                    {
                        if (count3 < 14)
                        {

                            count3++;
                        }
                    }
                    if (is_game_over == false)//if game is not over we decrease the player's score by 5.
                    {
                        if (game_counter % 2 == 0)
                        {
                            score_of_player_1 = score_of_player_1 - 5;
                        }
                        else if (game_counter % 2 == 1)
                        {
                            score_of_player_2 = score_of_player_2 - 5;
                        }
                        game_counter++; // and we increase the number of games by 1.
                        Console.WriteLine("P1- " + score_of_player_1 + " P2- " + score_of_player_2);
                        Console.ReadLine();
                    }

                    //now first we set our default arrays for names and scores.
                    if (is_game_over == true)
                    {
                        if (game_counter % 2 == 0)
                        {
                            score_of_player_1 = score_of_player_1 - 5;
                        }
                        else if (game_counter % 2 == 1)
                        {
                            score_of_player_2 = score_of_player_2 - 5;
                        }
                        Console.WriteLine("P1- " + score_of_player_1 + " P2- " + score_of_player_2);
                        int i = 0;
                        int j = 0;
                        int k = 0;
                        string newName = " ";
                        string[] names = { "Derya   ", "Elife   ", "Fatih   ", "Ali     ", "Azra    ", "Sibel   ", "Cem     ", "Nazan   ", "Mehmet  ", "Nil     ", "Can     ", "Tarkan  ", " " };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30, 0 };
                        //then we insert the new element to the arrays, and then print the arrays.
                        if (winner_player(game_counter) == "Winner is : Player 1  CONGRATULATIONS!")
                        {
                            newName = "Player1 ";

                            if (score_of_player_1 > scores[12])
                            {

                                for (k = 12; k >= 0; k--)
                                {
                                    if (scores[k] < score_of_player_1)
                                    {
                                        j = k;
                                    }
                                }
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("NAMES         SCORES");
                                Console.WriteLine("---------------------");
                                //if the player reaches the best score because of j=k j becomes 0
                                if (j > 0)// if we do not put this condition
                                {
                                    for (k = 12; k >= j; k--) // k becomes >=0
                                    {
                                        scores[k] = scores[k - 1];// therefore program does not work since k-1 becomes -1
                                        names[k] = names[k - 1];
                                    }
                                    scores[j] = score_of_player_1;
                                    names[j] = newName;
                                }
                                else
                                {
                                    for (k = 12; k >= 1; k--)
                                    {
                                        scores[k] = scores[k - 1];
                                        names[k] = names[k - 1];
                                    }
                                    scores[j] = score_of_player_1;
                                    names[j] = newName;
                                }

                                for (k = 0; k < 13; k++)
                                {
                                    if (names[k] =="Player1 ")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;

                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    Console.WriteLine(names[k] + "      " + scores[k]);
                                }
                            }
                        }
                        else if (winner_player(game_counter) == "Winner is : Player 2  CONGRATULATIONS")
                        {
                            newName = "Player2 ";

                            if (score_of_player_2 > scores[12])
                            {
                                for (k = 12; k >= 0; k--)
                                {
                                    if (scores[k] < score_of_player_2)
                                    {
                                        j = k;
                                    }
                                }


                                if (j > 0)
                                {
                                    for (k = 12; k >= j; k--)
                                    {
                                        scores[k] = scores[k - 1];
                                        names[k] = names[k - 1];
                                    }
                                    scores[j] = score_of_player_2;
                                    names[j] = newName;
                                }
                                else
                                {
                                    for (k = 12; k >= 1; k--)
                                    {
                                        scores[k] = scores[k - 1];
                                        names[k] = names[k - 1];
                                    }
                                    scores[j] = score_of_player_2;
                                    names[j] = newName;
                                }



                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("NAMES         SCORES");
                                Console.WriteLine("---------------------");

                                for (k = 0; k < 13; k++)
                                {   if(names[k]=="Player2 ")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;

                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }

                                    Console.WriteLine(names[k] + "      " + scores[k]);
                                }
                            }

                        }
                        Console.ReadLine();

                    }

                } while (is_game_over == false);

            }
        }
    }
}
