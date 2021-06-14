using System;
using System.Collections.Generic;
using System.Linq;


namespace Programming_Assignment_2_Summer_2021
{
	class Program
	{
		static void Main(string[] args)
		{
			//Question1:
			Console.WriteLine("Question 1");
			int[] nums1 = { 2, 5, 1, 3, 4, 7 };
			int[] nums2 = { 2, 1, 4, 7 };
			Intersection(nums1, nums2);
			Console.WriteLine("");


			//Question 2 
			Console.WriteLine("Question 2");
			int[] nums = { 0, 1, 0, 3, 12 };
			Console.WriteLine("Enter the target number:");
			int target = Int32.Parse(Console.ReadLine());
			int pos = SearchInsert(nums, target);
			Console.WriteLine("Insert Position of the target is : {0}", pos);
			Console.WriteLine("");


			//Question3
			Console.WriteLine("Question 3");
			int[] ar3 = { 1, 2, 3, 1, 1, 3 };
			int Lnum = LuckyNumber(ar3);
			if (Lnum == -1)
				Console.WriteLine("Given Array doesn't have any lucky Integer");
			else
				Console.WriteLine("Lucky Integer for given array {0}", Lnum);


			Console.WriteLine();


			//Question 4
			Console.WriteLine("Question 4");
			Console.WriteLine("Enter the value for n:");
			int n = Int32.Parse(Console.ReadLine());
			int Ma = GenerateNums(n);
			Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
			Console.WriteLine();


			//Question 5


			Console.WriteLine("Question 5");
			List<List<string>> cities = new List<List<string>>();
			cities.Add(new List<string>() { "London", "New York" });
			cities.Add(new List<string>() { "New York", "Tampa" });
			cities.Add(new List<string>() { "Delhi", "London" });
			string Dcity = DestCity(cities);
			Console.WriteLine("Destination City for Given Route is : {0}", Dcity);


			Console.WriteLine();


			//Question 6
			Console.WriteLine("Question 6");
			int[] Nums = { 2, 7, 11, 15 };
			int target_sum = 9;
			targetSum(Nums, target_sum);
			Console.WriteLine();


			//Question 7
			Console.WriteLine("Question 7");
			int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
			HighFive(scores);
			Console.WriteLine();


			//Question 8
			Console.WriteLine("Question 8");
			int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
			int K = 3;
			RotateArray(arr, K);


			Console.WriteLine();


			//Question 9
			Console.WriteLine("Question 9");
			int[] arr9 = { -2, -3, 4, -1, -2, 1, 5, -3 };
			int Ms = MaximumSum(arr9);
			Console.WriteLine("Maximun Sum contiguous subarray {0}", Ma);
			Console.WriteLine();


			//Question 10
			Console.WriteLine("Question 10");
			int[] costs = { 10, 15, 20 };
			int minCost = MinCostToClimb(costs);
			Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
			Console.WriteLine();
		}


		//Question 1
		/// <summary>
		//Given two integer arrays nums1 and nums2, return an array of their intersection.
		//Each element in the result must be unique and you may return the result in any order.
		//Example 1:
		//Input: nums1 = [1,2,2,1], nums2 = [2,2]
		//Output: [2]
		//Example 2:
		//Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
		//Output: [9,4]
		//
		/// </summary>


		public static void Intersection(int[] nums1, int[] nums2)
		{
			try
			{
				//Creating 2 hashsets (unordered collection) for the input arrays nums1 and nums2 
				HashSet<int> hashnums1 = new HashSet<int>(nums1);
				HashSet<int> hashnums2 = new HashSet<int>(nums2);

				//Using IntersectWith Method to store the Intersection of both the HashSet hashnums1 and hashnums2 
				hashnums1.IntersectWith(hashnums2);

				//Loop to print the intersected numbers stored in hashset hashnums1
				foreach (int i in hashnums1)
				{
					Console.WriteLine(i);

				}


			}
			catch (Exception)
			{


				throw;
			}
		}


		//Question 2:
		/// <summary>
		//Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
		//Note: You must write an algorithm with O(log n) runtime complexity.
		//Example 1:
		//Input: nums = [1, 3, 5, 6], target = 5
		//Output: 2
		//Example 2:
		//Input: nums = [1, 3, 5, 6], target = 2
		//Output: 1
		//Example 3:
		//Input: nums = [1, 3, 5, 6], target = 7
		//Output: 4
		//Example 4:
		//Input: nums = [1, 3, 5, 6], target = 0
		//Output: 0
		/// </summary>


		public static int SearchInsert(int[] nums, int target)
		{
			try
			{
				//Declaring the variables for low and high index number of array
				int low = 0;
				int high = nums.Length - 1;
				if (nums.Length == 0)
					return -1;
				//loop iterates till array length-1
				for(int i=0; i< nums.Length; i++) 
				{
					//taking  index number of mid of array length
					int mid = (high + low) / 2;
					//if target number is greater than the middle array
					if (nums[mid] < target)
					{
						low = mid + 1; // take the low index number as mid+1
					}
					//if the target number is less than the middle array
					else if (nums[mid] > target)
					{
						high = mid - 1; // take the high index number as mid_1
					}
					//if the target number is not found other than mid num, then it is the mid num
					else return mid;
				}
				return low;
			}
			catch (Exception)
			{
				throw;
			}
		}




		//Question 3
		/// <summary>
		//Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.
		//Return a lucky integer in the array. If there are multiple lucky integers return the largest of them. If there is no lucky integer return -1.
		//Example 1:
		//Input: arr = [2, 2, 3, 4]
		//Output: 2
		//Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
		/// </summary>


		private static int LuckyNumber(int[] nums)
		{
			try
			{
				//declaring dictionery with int key - value pair
				Dictionary<int, int> d = new Dictionary<int, int>();
				//checking number in array
				foreach (int n in nums)
				{
					//check if dictionery  contains the num or not
					if (!d.ContainsKey(n))
					{
						//if not, add the key and value to dict
						d.Add(n, 1);
					}
					else
					{
						//if not, increment the dict value by 1
						d[n] += 1;
					}
				}


				int largest = -1;
				//loop for every key value pair in dict
				foreach (KeyValuePair<int, int> kvp in d)
				{
					//if value equals key and if value is greater than largest int
					if (kvp.Value == kvp.Key && kvp.Value > largest)
					{
						//store value to the int largest var
						largest = kvp.Value;
					}
				}

				//return the largest value 
				return largest;
			
			}
			catch (Exception)
			{


				throw;
			}
		}


		//Question 4:
		/// <summary>
		//You are given an integer n.An array nums of length n + 1 is generated in the following way:
		//•	nums[0] = 0
		//•	nums[1] = 1
		//•	nums[2 * i] = nums[i]  when 2 <= 2 * i <= n
		//•	nums[2 * i + 1] = nums[i] + nums[i + 1] when 2 <= 2 * i + 1 <= n
		// Return the maximum integer in the array nums.


		//Example 1:
		//Input: n = 7
		//Output: 3
		//Explanation: According to the given rules:
		//nums[0] = 0
		//nums[1] = 1
		//nums[(1 * 2) = 2] = nums[1] = 1
		//nums[(1 * 2) + 1 = 3] = nums[1] + nums[2] = 1 + 1 = 2
		//nums[(2 * 2) = 4] = nums[2] = 1
		//nums[(2 * 2) + 1 = 5] = nums[2] + nums[3] = 1 + 2 = 3
		//nums[(3 * 2) = 6] = nums[3] = 2
		//nums[(3 * 2) + 1 = 7] = nums[3] + nums[4] = 2 + 1 = 3
		//Hence, nums = [0, 1, 1, 2, 1, 3, 2, 3], and the maximum is 3.


		/// </summary>
		private static int GenerateNums(int n)
		{
			try
			{
				//declare an array with length n+1
				int[] res = new int[n + 1];
				//if n <2 return the value if n
				if (n < 2)
				{
					return n;
				}
				//if n=> 2
				res[1] = 1;
				//loop from 1 to till twice the i value less than or equal to n value
				for (int i = 1; 2 * i <= n; i++)
				{
					//declared int variable to store the next value (i.e. twice of i)
					int next = 2 * i;
					res[next] = res[i]; // store in the  array r  
					//if array value+1 is less than n value
					if (next + 1 <= n)
					{
						//this logic -> nums[2 * i + 1] = nums[i] + nums[i + 1]
						res[next + 1] = res[i] + res[i + 1];
					}
				}
				//return the maximum value in the array
				return res.Max();
			
			}
			catch (Exception)
			{


				throw;
			}


		}


		//Question 5
		/// <summary>
		//You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi.Return the destination city, that is, the city without any path outgoing to another city.
		//It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
		//Example 1:
		//Input: paths = [["London", "New York"], ["New York","Lima"], ["Lima","Sao Paulo"]]
		//Output: "Sao Paulo" 
		//Explanation: Starting at "London" city you will reach "Sao Paulo" city which is the destination city.Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".
		/// </summary>
		public static string DestCity(List<List<string>> paths)
		{
			try
			{
				//Declaring string List 
				List<string> newlist = new List<string>();

				//loop to check path in list paths
				foreach (var path in paths)
				{
					//add first value of list paths to newlist
					newlist.Add(path[1]);
				}
				// loop to check path in list paths
				foreach (var path in paths)
				{
					//check if newlist has that path already in it or not
					if (newlist.Contains(path[0]))
					{
						//if contains, remove the path from the list
						newlist.Remove(path[0]);
					}

				}
				//return the last path in the newlist
				return newlist.Last();
			
			}
			catch (Exception)
			{


				throw;
			}
		}


		//Question 6:
		/// <summary>
		//Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
		//Print the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.Length.
		//You may not use the same element twice, there will be only one solution for a given array
		//Example 1:
		//Input: numbers = [2,7,11,15], target = 9
		//Output: [1,2]
		//Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.


		/// </summary>
		private static void targetSum(int[] nums, int target)
		{
			try
			{
				//declared initial variables
				int leftnum = 0;
				int rightnum = nums.Length - 1;
				//check if length is greater than or equal to 2 and the arr length is less than or equal to (3 * 104)
				if (nums.Length >= 2 && nums.Length <= (3 * 104))
				{
					//traverse till left num is less than rigth
					while (leftnum < rightnum)
					{
						//checking the contraint -1000 <= numbers[i] <= 1000
						if (nums[leftnum] >= -1000 && nums[rightnum] >= -1000
							&& nums[leftnum] <= 1000 && nums[rightnum] <= 1000)
						{ 
							//the added array values are less than target or not
							if ((nums[leftnum] + nums[rightnum]) < target)
								leftnum++;
							else if ((nums[leftnum] + nums[rightnum]) > target)
								rightnum--; // else increase rightnumber
							else if ((nums[leftnum] + nums[rightnum]) == target)//else break the loop
								break;
						}
						else
							throw new Exception();
					}
				}
				else
					throw new Exception();
				Console.WriteLine("{0},{1}", leftnum + 1, rightnum + 1);



			}
			catch (Exception)
			{


				throw;
			}
		}


		//Question 7
		/// <summary>
		/// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
		/// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
		/// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
		/// Example 1:
		/// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
		/// Output: [[1,87],[2,88]]
		/// Explanation: 
		/// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
		/// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
		/// Example 2:
		/// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
		/// Output: [[1,100],[7,100]]
		/// Constraints:
		/// 1 <= items.length <= 1000
		/// items[i].length == 2
		/// 1 <= IDi <= 1000
		/// 0 <= scorei <= 100
		/// For each IDi, there will be at least five scores.
		/// </summary>
		private static void HighFive(int[,] items)
		{


			try
			{
				// declare list of int datatype
				List<int[]> list = new List<int[]>();
				List<int[,]> res = new List<int[,]>();
				//traverse till array's 1st value length
				for (int i = 0; i < items.GetLength(0); i++)
				{
					//add the values in the list
					list.Add(new int[] { items[i, 0], items[i, 1] });
				}
				//sort the list using lambda function and store the list parameters
				list.Sort((p, q) => { return (p[0] < q[0]) ? -1 :
									((p[0] == q[0]) ? ((p[1] <= q[1]) ? 1 : -1) : 1); });
				int first = list[0][0];
				int count = 1;
				int sum = list[0][1];

				//traverse till parameters count in list
				for (int i = 1; i < list.Count; i++)
				{
					//if the pair in list is equal to the 1st pair present at list and if the count is less than 5 
					if (list[i][0] == first && count < 5)
					{
						sum += list[i][1];
						count += 1;
					}
					//if not, check if the value is already equal to the first value of list
					else if (list[i][0] != first)
					{
						//add the parameters in list, the first value and the sum value divided by 5 to achieve the prob constraint 'five average'
						res.Add(new int[,] { { first, sum / 5 } });

						Console.Write("[[" + first + "," + sum / 5 + "]" + ",");
						first = list[i][0];
						count = 1;
						sum = list[i][1];
					}
				}
				//add the final list parameters with the average of 5 students as well
				res.Add(new int[,] { { first, sum / 5 } });
				Console.Write("[" + first + "," + sum / 5 + "]]");
				Console.Write("\n");

			}
			catch (Exception)
			{

				throw;
			}
		}




//Question 8
/// <summary>
//Given an array, rotate the array to the right by k steps, where k is non-negative.
//Print the Final array after rotation.
//Example 1:
//Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
//Output: [5,6,7,1,2,3,4]
//Explanation:
//rotate 1 steps to the right: [7,1,2,3,4,5,6]
//rotate 2 steps to the right: [6,7,1,2,3,4,5]
//rotate 3 steps to the right: [5,6,7,1,2,3,4]
//Example 2:
//Input: nums = [-1,-100,3,99], k = 2
//Output: [3,99,-1,-100]
//Explanation: 
//rotate 1 steps to the right: [99,-1,-100,3]
//rotate 2 steps to the right: [3,99,-1,-100]
/// </summary>


private static void RotateArray(int[] arr, int n)
		{
			try
			{
				int len = arr.Length;
				// to check if any parameter is null
				if (arr == null || len <= 1 || (n % len) == 0)
					return;
				//declared variables
				int init = 0, start = 0, k = len, current = arr[0];
				//loop till k is greater than 0
				while (k > 0)
				{
					//taking values of len percent to the total
					int index = (start + n) % len;
					int tmp = arr[index]; // take that value of array to tmp var
					arr[index] = current; //taking 1st array value
					start = index;
					current = tmp;
					k--;
					// loop if init has equal value of start
					if (init == start)
					{
						//increment start
						start += 1;
						init = start;
						// take that array vaue into current
						current = arr[start];
					}
				
			}

			}
			catch (Exception)
			{


				throw;
			}
		}


		//Question 9
		/// <summary>
		//Given an integer array nums, find the contiguous subarray(containing at least one number)
		//which has the largest sum and return its sum
		//Example 1:
		//Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
		//Output: 6
		//Explanation: [4,-1,2,1] has the largest sum = 6.
		//Example 2:
		//Input: nums = [1]
		//Output: 1
		// Example 3:
		// Input: nums = [5,4,-1,7,8]
		//Output: 23
		/// </summary>


		private static int MaximumSum(int[] arr)
		{
			try
			{
				//declared int variables to store the start,end,max, min array numbers
				int max_num = int.MinValue,
				max_last = 0, start = 0,
				endnum = 0, z = 0;
				//traverse till array length
				for (int i = 0; i < arr.Length; i++)
				{
					//add the array values and store in max_last variable
					max_last += arr[i];
					//check if the max number in less than the last num in the array
					if (max_num < max_last)
					{
						//then store the last num of array in the max number variable
						max_num = max_last;
						start = z;
						endnum = i;
					}
					// check if last array value is less than 0 or not
					if (max_last < 0)
					{
						max_last = 0;
						z = i + 1;
					}
				}
				Console.WriteLine("Maximum contiguous " +
								 "sum is " + max_num);
				Console.WriteLine("Starting index " +
											  start);
				Console.WriteLine("Ending index " +
											  endnum);
			//return the maximum number to main function
			return max_num;
		
			}
			catch (Exception)
			{


				throw;
			}
		}


		//Question 10
		/// <summary>
		//You are given an integer array cost where cost[i] is the cost of ith step on a staircase.Once you pay the cost, you can either climb one or two steps.
		//You can either start from the step with index 0, or the step with index 1.
		//Return the minimum cost to reach the top of the floor.
		//Example 1:
		//Input: cost = [10, 15, 20]
		//Output: 15
		//Explanation: Cheapest is: start on cost[1], pay that cost, and go to the top.


		/// </summary>


		private static int MinCostToClimb(int[] costs)
		{
			try
			{
				//Declared the variables for taking array values
				int Cost1 = costs[0];
				int Cost2 = costs[1];
				int currentCost = 0;
				//traverse till array length
				for (int i = 2; i < costs.Length; i++)
				{
					//take sum of ith array value and minimum of cost1 and cost2
					currentCost = costs[i] + Math.Min(Cost1, Cost2);
					Cost1 = Cost2;
					Cost2 = currentCost;
				}
				//Return the minimum cost to reach the top of the floor.
				return Math.Min(Cost1, Cost2);




			}
			catch (Exception)
			{


				throw;
			}
		}
	}
}

