﻿using GMI24H_Labb5_Grupp_ERTGRUPPNR.MyAlgorithmLibrary;
using System.Diagnostics;


/// <summary>
/// NOTE: You are by no means obligated to use this project structure. It is just a suggestion. If you want to create
/// your own project from scratch, you are most welcome to do so.
/// 
/// In the Program class you have the Main methods which is the starting point of any program which I am sure that you
/// already are aware of. Normally, it is not appropriate to keep this much code within the Main method so you should consider
/// to move some of the code to other classes and methods. However, the important thing is that you can test your algorithms
/// and that you can show that they work.
/// 
/// Please write comments in your own code for specific test cases or other things that you want to show.
/// It is ok to write your code in English and your comments in Swedish. However, do not mix Enlish and Swedish IN THE CODE.
/// Another way to go ahead with the testing is to write unit tests. It is very much up to you how you decide to 
/// organize your work.
/// 
/// Best of luck! /Elin
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //Here you are given some predefined arrays to test your algorithms on.
        //Please note that in order to make any conclusions about the performance of your algorithms, you need to test them on larger arrays.


        //1000 random numbers (range: 1 - 100)
        int[] randomNumbers = { 60, 43, 18, 18, 100, 84, 51, 40, 41, 4, 69, 36, 27, 34, 88, 93, 46, 81, 95, 31, 80, 83, 63, 99, 59, 31, 85, 19, 48, 85, 61, 67, 62, 4, 70, 35, 15, 78, 52, 61, 54, 76, 28, 70, 29, 68, 1, 92, 31, 98, 96, 21, 74, 60, 38, 39, 85, 91, 26, 52, 96, 74, 45, 24, 100, 78, 21, 12, 81, 60, 31, 28, 45, 82, 59, 48, 92, 41, 40, 55, 100, 83, 96, 31, 66, 92, 73, 32, 63, 25, 54, 63, 96, 41, 89, 48, 86, 2, 64, 61, 17, 100, 58, 2, 8, 97, 100, 58, 65, 93, 91, 46, 16, 9, 88, 10, 36, 18, 70, 79, 97, 45, 59, 39, 48, 91, 84, 59, 47, 75, 1, 34, 3, 77, 5, 67, 100, 6, 27, 97, 29, 28, 93, 100, 67, 58, 22, 85, 41, 51, 81, 10, 53, 37, 10, 100, 47, 65, 34, 96, 74, 8, 100, 67, 56, 45, 50, 16, 31, 25, 63, 9, 81, 61, 86, 57, 72, 9, 32, 25, 77, 21, 45, 2, 48, 17, 5, 15, 78, 11, 60, 26, 72, 50, 29, 89, 28, 42, 16, 23, 89, 13, 37, 30, 60, 72, 88, 97, 39, 83, 76, 97, 99, 20, 18, 93, 73, 77, 27, 14, 50, 43, 7, 74, 65, 74, 5, 8, 55, 14, 84, 50, 33, 62, 27, 70, 51, 1, 12, 98, 33, 20, 81, 9, 12, 86, 65, 48, 69, 24, 22, 10, 20, 95, 54, 53, 63, 79, 54, 36, 31, 86, 41, 20, 36, 33, 7, 82, 63, 58, 47, 65, 51, 69, 66, 94, 43, 30, 15, 77, 68, 91, 51, 39, 93, 83, 14, 84, 33, 49, 17, 26, 36, 53, 24, 60, 55, 3, 87, 58, 37, 78, 9, 44, 64, 82, 10, 69, 41, 81, 68, 55, 40, 8, 61, 42, 5, 77, 82, 1, 67, 5, 32, 17, 78, 52, 19, 51, 46, 19, 76, 16, 72, 92, 49, 54, 29, 18, 3, 27, 7, 87, 73, 97, 57, 92, 99, 55, 81, 80, 33, 89, 92, 51, 95, 16, 54, 89, 3, 83, 12, 97, 31, 52, 13, 100, 3, 34, 46, 6, 38, 84, 70, 96, 90, 50, 81, 26, 17, 14, 44, 62, 56, 81, 27, 83, 15, 33, 72, 80, 34, 52, 91, 62, 4, 96, 41, 50, 58, 4, 69, 61, 67, 98, 35, 99, 44, 33, 52, 69, 43, 1, 62, 42, 71, 34, 70, 22, 7, 4, 41, 83, 25, 10, 3, 59, 60, 71, 87, 54, 10, 85, 97, 34, 56, 96, 62, 81, 37, 51, 22, 99, 100, 35, 59, 9, 55, 25, 77, 87, 61, 58, 23, 32, 10, 71, 95, 4, 41, 39, 97, 13, 88, 10, 87, 41, 65, 13, 32, 7, 72, 70, 30, 90, 3, 40, 50, 51, 24, 50, 49, 96, 88, 65, 70, 50, 38, 70, 26, 78, 6, 86, 93, 42, 51, 28, 47, 21, 75, 46, 70, 63, 86, 94, 25, 7, 98, 71, 50, 87, 66, 99, 31, 12, 82, 62, 87, 93, 39, 13, 77, 56, 42, 66, 96, 10, 47, 96, 59, 6, 71, 97, 53, 90, 39, 49, 23, 51, 72, 18, 58, 100, 3, 55, 49, 34, 24, 12, 46, 72, 75, 58, 57, 1, 65, 39, 16, 76, 94, 72, 48, 10, 64, 45, 53, 42, 95, 7, 73, 96, 79, 85, 63, 43, 39, 62, 1, 91, 24, 70, 66, 97, 47, 46, 73, 53, 77, 21, 13, 85, 88, 42, 58, 60, 8, 85, 22, 54, 11, 14, 9, 82, 15, 12, 72, 7, 91, 37, 86, 90, 99, 73, 45, 22, 61, 42, 100, 73, 10, 30, 12, 72, 45, 95, 57, 83, 31, 97, 89, 5, 57, 94, 93, 81, 74, 12, 2, 83, 85, 92, 61, 94, 88, 77, 7, 87, 25, 48, 93, 50, 44, 22, 82, 70, 62, 42, 94, 33, 75, 64, 77, 71, 41, 22, 36, 74, 81, 79, 55, 19, 42, 61, 79, 75, 45, 36, 16, 4, 97, 16, 19, 86, 25, 31, 46, 54, 66, 48, 70, 12, 20, 74, 72, 14, 15, 97, 16, 14, 9, 3, 61, 92, 49, 12, 74, 66, 57, 16, 14, 80, 94, 82, 36, 82, 64, 74, 47, 7, 100, 39, 85, 63, 59, 46, 4, 78, 24, 33, 50, 75, 3, 89, 73, 38, 42, 56, 63, 70, 48, 36, 75, 49, 32, 77, 32, 36, 73, 3, 38, 72, 65, 96, 40, 2, 46, 44, 85, 96, 95, 85, 61, 87, 59, 39, 58, 65, 85, 51, 19, 43, 83, 32, 34, 84, 35, 26, 56, 57, 43, 12, 35, 52, 100, 99, 63, 92, 17, 60, 31, 83, 61, 8, 16, 40, 41, 39, 44, 4, 69, 64, 37, 77, 67, 11, 51, 43, 76, 12, 42, 7, 90, 18, 32, 13, 87, 27, 84, 8, 80, 80, 43, 6, 25, 56, 7, 61, 38, 62, 31, 9, 28, 33, 63, 96, 12, 55, 34, 75, 56, 69, 31, 17, 9, 8, 70, 62, 36, 12, 9, 91, 85, 65, 18, 93, 24, 5, 19, 63, 70, 18, 29, 25, 74, 29, 55, 85, 56, 63, 90, 13, 31, 100, 68, 33, 94, 74, 10, 11, 3, 37, 10, 26, 49, 14, 11, 87, 93, 94, 68, 99, 36, 71, 98, 70, 92, 19, 45, 71, 47, 8, 65, 73, 35, 65, 1, 28, 43, 13, 59, 99, 22, 29, 7, 36, 39, 43, 93, 97, 11, 6, 1, 72, 74, 64, 98, 10, 76, 42, 78, 17, 93, 52, 20, 23, 50, 23, 39, 26, 87, 29, 36, 14, 17, 81, 82, 10, 44, 73, 63, 17, 74, 74, 54, 95, 27, 100, 73, 70, 44, 20, 7, 83, 9, 34, 24, 80, 53, 74, 47, 43, 84, 41, 22, 81, 15, 5, 34, 67, 58, 62, 66, 69, 82, 2, 39, 91, 79, 75, 56, 35, 53, 79, 62, 50, 44, 43, 70, 54, 36, 90 };
        
        //1000 sorted numbers (range: 1 - 100)
        int[] sortedNumbers = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 14, 14, 15, 15, 15, 15, 15, 15, 15, 15, 15, 16, 16, 16, 16, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 18, 18, 18, 18, 18, 18, 18, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 21, 21, 21, 21, 21, 21, 21, 21, 21, 22, 22, 22, 22, 22, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23, 23, 24, 24, 24, 24, 25, 25, 25, 25, 25, 25, 25, 25, 26, 26, 26, 26, 26, 26, 27, 27, 27, 27, 27, 27, 27, 27, 28, 28, 28, 28, 28, 28, 28, 28, 28, 29, 29, 29, 29, 29, 30, 30, 30, 30, 30, 30, 30, 30, 31, 31, 31, 31, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 38, 38, 38, 38, 38, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 42, 42, 42, 42, 42, 43, 43, 43, 43, 43, 43, 43, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 45, 45, 45, 45, 45, 45, 45, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 49, 49, 49, 49, 49, 49, 49, 49, 50, 50, 50, 50, 50, 50, 50, 51, 51, 51, 51, 51, 51, 51, 51, 52, 52, 52, 52, 52, 52, 52, 52, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 54, 54, 54, 54, 54, 54, 54, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 56, 56, 56, 56, 56, 56, 56, 56, 56, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 64, 64, 64, 64, 64, 64, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 67, 67, 67, 67, 67, 67, 67, 67, 67, 67, 67, 67, 67, 68, 68, 68, 68, 68, 68, 68, 68, 68, 69, 69, 69, 69, 69, 69, 70, 70, 70, 70, 70, 70, 70, 70, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 73, 73, 73, 73, 73, 73, 73, 73, 73, 74, 74, 74, 74, 74, 74, 74, 74, 75, 75, 75, 75, 75, 75, 75, 75, 75, 75, 76, 76, 76, 76, 76, 76, 76, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 78, 78, 78, 78, 78, 78, 79, 79, 79, 79, 79, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 81, 81, 81, 81, 81, 81, 81, 81, 81, 81, 82, 82, 82, 82, 82, 82, 82, 82, 82, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 84, 84, 84, 84, 84, 84, 84, 84, 84, 85, 85, 85, 85, 85, 85, 85, 85, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 87, 87, 87, 87, 87, 87, 87, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 89, 89, 89, 89, 89, 89, 89, 89, 89, 89, 89, 89, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 91, 91, 91, 91, 91, 91, 91, 91, 92, 92, 92, 92, 92, 92, 92, 92, 92, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 93, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 95, 95, 95, 95, 95, 95, 95, 95, 95, 96, 96, 96, 96, 96, 96, 96, 97, 97, 97, 97, 97, 97, 97, 97, 97, 97, 97, 97, 97, 97, 97, 97, 98, 98, 98, 98, 98, 98, 98, 98, 98, 98, 98, 99, 99, 99, 99, 99, 99, 99, 99, 100, 100, 100, 100, 100, 100 };

        //1000 reverse sorted numbers
        int[] reversedSortedNumbers = { 100, 100, 100, 100, 100, 100, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 98, 98, 98, 98, 98, 98, 98, 98, 98, 97, 97, 97, 97, 97, 97, 97, 97, 96, 96, 96, 96, 96, 96, 96, 96, 96, 96, 96, 95, 95, 95, 95, 95, 95, 95, 95, 95, 95, 95, 95, 95, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 93, 93, 93, 93, 93, 93, 93, 93, 92, 92, 92, 92, 92, 92, 92, 92, 92, 91, 91, 91, 91, 91, 91, 91, 91, 91, 91, 91, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 89, 89, 89, 89, 89, 89, 89, 89, 89, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 86, 86, 86, 86, 86, 86, 86, 86, 86, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 84, 84, 84, 84, 84, 84, 84, 84, 84, 84, 84, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 82, 82, 82, 82, 82, 82, 82, 82, 82, 82, 81, 81, 81, 81, 81, 81, 81, 81, 81, 81, 81, 80, 80, 80, 80, 80, 80, 80, 80, 79, 79, 79, 79, 79, 79, 79, 79, 78, 78, 78, 78, 78, 78, 78, 78, 78, 78, 78, 78, 78, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 76, 76, 76, 76, 76, 76, 76, 75, 75, 75, 75, 75, 75, 75, 74, 74, 74, 74, 74, 74, 74, 74, 74, 74, 74, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 71, 71, 71, 71, 71, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 68, 68, 68, 68, 68, 68, 68, 67, 67, 67, 67, 67, 67, 67, 66, 66, 66, 66, 66, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 63, 63, 63, 63, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 61, 61, 61, 61, 61, 61, 61, 60, 60, 60, 60, 60, 60, 60, 60, 59, 59, 59, 59, 59, 59, 58, 58, 58, 58, 58, 58, 58, 57, 57, 57, 57, 57, 57, 57, 57, 56, 56, 56, 56, 56, 56, 56, 56, 56, 55, 55, 55, 55, 55, 55, 54, 54, 54, 54, 54, 54, 54, 54, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 52, 52, 52, 52, 52, 52, 52, 52, 51, 51, 51, 51, 51, 51, 50, 50, 50, 50, 50, 50, 50, 50, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 43, 43, 43, 43, 43, 43, 43, 43, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 40, 40, 40, 40, 40, 40, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 35, 35, 35, 35, 35, 35, 35, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 32, 32, 32, 32, 32, 32, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 25, 25, 25, 25, 25, 25, 25, 25, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 22, 22, 22, 22, 22, 21, 21, 21, 21, 21, 21, 21, 21, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 18, 18, 18, 18, 18, 18, 18, 18, 18, 17, 17, 17, 17, 17, 17, 16, 16, 16, 16, 16, 16, 16, 16, 16, 15, 15, 15, 15, 15, 15, 15, 15, 14, 14, 14, 14, 14, 14, 14, 14, 13, 13, 13, 13, 13, 13, 12, 12, 12, 12, 12, 12, 12, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 9, 9, 9, 9, 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 4, 4, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        //1000 nearly sorted numbers
        int[] nearlySortedNumbers = { 1, 1, 1, 2, 1, 1, 1, 1, 2, 2, 2, 4, 2, 2, 2, 6, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 3, 4, 4, 4, 4, 4, 5, 4, 4, 5, 5, 5, 5, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 5, 6, 6, 6, 6, 6, 6, 6, 6, 7, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 5, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 10, 10, 13, 10, 10, 10, 10, 10, 10, 16, 11, 11, 11, 11, 11, 11, 11, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 15, 15, 15, 15, 15, 15, 15, 15, 15, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 17, 16, 17, 17, 17, 17, 16, 18, 18, 18, 18, 18, 18, 18, 18, 17, 18, 18, 18, 18, 18, 19, 19, 19, 19, 19, 19, 19, 19, 20, 20, 20, 20, 20, 20, 20, 20, 20, 21, 21, 21, 21, 21, 21, 21, 21, 21, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 26, 26, 26, 26, 27, 27, 27, 27, 27, 27, 27, 27, 27, 28, 28, 28, 29, 29, 29, 29, 29, 29, 29, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 32, 32, 32, 32, 32, 33, 33, 33, 32, 33, 33, 33, 33, 34, 34, 34, 34, 35, 34, 34, 35, 35, 35, 35, 35, 35, 35, 36, 36, 36, 36, 35, 36, 36, 36, 36, 37, 37, 37, 37, 36, 37, 37, 37, 37, 37, 37, 38, 38, 38, 38, 38, 38, 38, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 40, 40, 40, 40, 40, 40, 40, 41, 41, 41, 41, 41, 41, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 47, 47, 47, 47, 48, 48, 47, 48, 48, 48, 49, 48, 48, 49, 49, 49, 49, 49, 49, 47, 49, 49, 49, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 51, 51, 51, 51, 51, 51, 51, 51, 51, 51, 52, 52, 52, 52, 52, 52, 52, 52, 52, 52, 52, 53, 53, 53, 53, 53, 53, 53, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 56, 56, 56, 56, 56, 56, 56, 56, 56, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 58, 58, 58, 58, 58, 58, 58, 58, 57, 58, 58, 58, 58, 60, 58, 59, 59, 59, 59, 61, 59, 58, 59, 59, 59, 60, 60, 60, 60, 61, 60, 60, 61, 61, 61, 61, 61, 61, 61, 61, 61, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 64, 64, 64, 64, 64, 64, 64, 64, 65, 65, 65, 65, 65, 65, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 67, 67, 67, 67, 67, 67, 67, 67, 67, 66, 67, 67, 67, 68, 68, 68, 68, 68, 66, 68, 67, 68, 68, 69, 73, 69, 69, 69, 69, 67, 69, 70, 70, 70, 73, 70, 70, 70, 70, 70, 72, 71, 71, 71, 71, 70, 72, 72, 72, 72, 72, 76, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 74, 74, 74, 74, 74, 74, 74, 74, 75, 75, 75, 75, 75, 75, 76, 76, 76, 76, 76, 77, 77, 77, 77, 77, 79, 77, 78, 78, 78, 78, 78, 74, 78, 78, 78, 78, 79, 77, 79, 79, 79, 79, 79, 80, 79, 79, 79, 79, 73, 80, 80, 80, 80, 80, 80, 80, 81, 81, 81, 81, 81, 81, 81, 81, 81, 81, 82, 82, 82, 82, 82, 82, 82, 82, 83, 83, 83, 83, 83, 83, 83, 83, 83, 84, 84, 84, 84, 84, 81, 84, 84, 88, 85, 85, 85, 88, 85, 85, 85, 85, 89, 85, 85, 86, 82, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 89, 89, 89, 89, 89, 89, 89, 90, 93, 90, 90, 90, 97, 90, 90, 95, 91, 91, 91, 91, 96, 91, 89, 91, 91, 92, 92, 92, 92, 92, 92, 92, 92, 92, 92, 92, 92, 92, 92, 93, 93, 93, 93, 93, 93, 93, 93, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 94, 95, 95, 95, 95, 95, 95, 95, 91, 95, 99, 95, 89, 95, 95, 95, 95, 96, 96, 96, 96, 96, 96, 96, 97, 97, 97, 97, 97, 97, 98, 98, 98, 98, 98, 98, 98, 98, 98, 98, 98, 98, 99, 99, 99, 99, 92, 99, 97, 99, 100, 95, 100, 100, 98, 100, 100, 93, 100, 100, 91, 100, 98, 100, 100, 100, 100 };


        //Since the methods in the Sorter and Searcher classes are not static, you need to create an object of each class
        //in order to call the methods which consist your algorithms.
        Sorter sorter = new Sorter();
        Searcher searcher = new Searcher();

        //To be able to measure how long it takes to run an algorithm, you can use
        //The Stopwatch and the TimeSpan classes.
        
        Stopwatch sw = Stopwatch.StartNew();
        //this is an appropriate place to run your algorithm.
        sw.Stop();
        TimeSpan elapsedTime = sw.Elapsed; //perhaps might be a good idea to do something with this...

    }
}