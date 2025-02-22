﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var poolOfPlayers = new Dictionary<string, List<Dictionary<string, int>>>();
            var poolOfPlayers = new Dictionary<string, Dictionary<string, int>>();

            string command;

            while ((command = Console.ReadLine()) != "Season end")
            {
                string[] splitArray = { "->", "vs" };
                string[] commandTokens = command
                    .Split(splitArray, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                if (command.Contains("vs"))
                {
                    string player1 = commandTokens[0];
                    string player2 = commandTokens[1];
                    string winner = string.Empty;
                    bool isValid = false;


                    if (!poolOfPlayers.ContainsKey(player1) || !poolOfPlayers.ContainsKey(player2))
                    {
                        continue;
                    }
                    int sumPlayer1 = 0;
                    int sumPlayer2 = 0;
                    foreach (var positionsOfPlayer1 in poolOfPlayers[player1])
                    {
                        sumPlayer1 += positionsOfPlayer1.Value;


                        foreach (var positionsOfPlayer2 in poolOfPlayers[player2])
                        {
                            sumPlayer2 += positionsOfPlayer2.Value;
                            if (positionsOfPlayer2.Key == positionsOfPlayer1.Key)
                            {
                                //if(positionsOfPlayer1.Value > positionsOfPlayer2.Value)
                                //{
                                //    winner = "player1";
                                //}
                                //else if(positionsOfPlayer2.Value > positionsOfPlayer1.Value)
                                //{
                                //    winner = "player2";
                                //}
                                isValid = true;
                            }
                        }
                    }
                    if (!isValid)
                    {
                        continue;
                    }
                    if (sumPlayer1 > sumPlayer2)
                    {
                        poolOfPlayers.Remove(player2);
                    }
                    else if (sumPlayer1 < sumPlayer2)
                    {
                        poolOfPlayers.Remove(player1);
                    }
                }
                else
                {
                    string playerName = commandTokens[0];
                    string position = commandTokens[1];
                    int skill = int.Parse(commandTokens[2]);

                    if (!poolOfPlayers.ContainsKey(playerName))
                    {
                        var newPlayerList = new List<Dictionary<string, int>>();
                        var newPlayerDict = new Dictionary<string, int>();
                        newPlayerDict.Add(position, skill);
                        newPlayerList.Add(newPlayerDict);
                        //poolOfPlayers.Add(playerName, newPlayerList);
                        poolOfPlayers.Add(playerName, newPlayerDict);
                    }
                    else
                    {
                        //foreach(var positionDict in poolOfPlayers[playerName])
                        //{
                        //    if (positionDict.ContainsKey(position))
                        //    {
                        //        if (positionDict[position] < skill)
                        //        {
                        //            positionDict[position] = skill;
                        //        }
                        //    }
                        //    else
                        //    {
                        //        positionDict.Add(position, skill);
                        //    }
                        //}

                        if (poolOfPlayers[playerName].ContainsKey(position))
                        {
                            if (poolOfPlayers[playerName][position] < skill)
                            {
                                poolOfPlayers[playerName][position] = skill;
                            }
                        }
                        else
                        {
                            poolOfPlayers[playerName].Add(position, skill);
                        }
                    }
                }

            }

            foreach (var player in poolOfPlayers)
            {
                int total = 0;
                foreach (var player1 in player.Value)
                {
                    total += player1.Value;
                }
                player.Value.Add("total", total);
            }

            var orderedPoolOfPlayers = poolOfPlayers
                .OrderByDescending(x => x.Value["total"])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in orderedPoolOfPlayers)
            {
                var totalSkill = 0;
                foreach (var skill in pair.Value)
                {
                    if (skill.Key == "total")
                    {
                        totalSkill = skill.Value;
                    }
                }
                Console.WriteLine($"{pair.Key}: {totalSkill} skill");
                var orderedForEachPlayer = pair
                    .Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (var positionAndSkill in orderedForEachPlayer)
                {
                    if ("total" != positionAndSkill.Key)
                    {
                        Console.WriteLine($"- {positionAndSkill.Key} <::> {positionAndSkill.Value}");
                    }
                }
            }
        }
    }
}
