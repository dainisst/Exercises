using System;

namespace Exercises.Level1;

/// <summary>
/// Medium array problems at least one loop.
/// </summary>
public class Array2
{
    /// <summary>
    ///  Return the number of even ints in the given array. Note: the % "mod" operator computes
    ///  the remainder, e.g. 5 % 2 is 1.
    /// 
    /// countEvens([2, 1, 2, 3, 4]) → 3
    /// countEvens([2, 2, 0]) → 3
    /// countEvens([1, 3, 5]) → 0
    /// </summary>
    public int CountEvens(int[] nums)
    {
        int leng = nums.Length;
        int even = 0;
        for (int i = 0; i < leng; i++)
        {
            if (nums[i] % 2 == 0)
            {
                even++;
            }

        }
        return even;
    }

    /// <summary>
    /// Given an array length 1 or more of ints, return the difference between the largest and
    /// smallest values in the array. Note: the built-in Math.min(v1, v2) and Math.max(v1, v2)
    /// methods return the smaller or larger of two values.
    /// 
    /// bigDiff([10, 3, 5, 6]) → 7
    /// bigDiff([7, 2, 10, 9]) → 8
    /// bigDiff([2, 10, 7, 2]) → 8
    /// </summary>
    public int BigDiff(int[] nums)
    {
        int max = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        int min = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        return max - min;
    }

    /// <summary>
    /// Return the "centered" average of an array of ints, which we'll say is the mean average of
    /// the values, except ignoring the largest and smallest values in the array. If there are
    /// multiple copies of the smallest value, ignore just one copy, and likewise for the largest
    /// value. Use int division to produce the final average. You may assume that the array is
    /// length 3 or more.
    /// 
    /// centeredAverage([1, 2, 3, 4, 100]) → 3
    /// centeredAverage([1, 1, 5, 5, 10, 8, 7]) → 5
    /// centeredAverage([-10, -4, -2, -4, -2, 0]) → -3
    /// </summary>
    public int CenteredAverage(int[] nums)
    {
        int max = nums[0];
        int min = nums[0];
        int leng = nums.Length;
        int sum = 0;
        for (int i = 0; i < leng; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        for (int i = 0; i < leng; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }
        for (int i = 0; i < leng; i++)
        {
            sum = sum + nums[i];
        }
        int mean = (sum - min - max) / (leng - 2);


        return mean;
    }

    /// <summary>
    /// Return the sum of the numbers in the array, returning 0 for an empty array. Except the
    /// number 13 is very unlucky, so it does not count and number that come immediately after
    /// a 13 also do not count.
    /// 
    /// sum13([1, 2, 2, 1]) → 6
    /// sum13([1, 1]) → 2
    /// sum13([1, 2, 2, 1, 13]) → 6
    /// </summary>
    public int Sum13(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 13)
            {
                i++;
            }
            else
            {
                sum = sum + nums[i];
            }
        }


        //int place13 = Array.IndexOf(nums, 13);
        //if (place13 > 0)
        //{
        //    sum = sum - 13 - nums[place13 + 1];
        //}

        return sum;
    }

    /// <summary>
    /// Return the sum of the numbers in the array, except ignore sections of numbers starting
    /// with a 6 and extending to the next 7 (every 6 will be followed by at least one 7). Return 0
    /// for no numbers.
    /// 
    /// sum67([1, 2, 2]) → 5
    /// sum67([1, 2, 2, 6, 99, 99, 7]) → 5
    /// sum67([1, 1, 6, 7, 2]) → 4
    /// </summary>
    public int Sum67(int[] nums)
    {
        //nepareizi
        int sum = 0;
        var ignore = false;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 6)
            {
                ignore = true;
            }
            else if (nums[i] == 7 && ignore)
            {
                ignore = false;
            }
            else if (!ignore)
            {
                sum = sum + nums[i];
            }
        }
        return sum;
    }

    /// <summary>
    /// Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
    /// 
    /// has22([1, 2, 2]) → true
    /// has22([1, 2, 1, 2]) → false
    /// has22([2, 1, 2]) → false
    /// </summary>
    public bool Has22(int[] nums)
    {
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 2 && nums[i - 1] == 2)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if the array contains no 1's and no 3's.
    /// 
    /// lucky13([0, 2, 4]) → true
    /// lucky13([1, 2, 3]) → false
    /// lucky13([1, 2, 4]) → false
    /// </summary>
    public bool Lucky13(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1 || nums[i] == 3)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Given an array of ints, return true if the sum of all the 2's in the array is exactly 8.
    /// 
    /// sum28([2, 3, 2, 2, 4, 2]) → true
    /// sum28([2, 3, 2, 2, 4, 2, 2]) → false
    /// sum28([1, 2, 3, 4]) → false
    /// </summary>
    public bool Sum28(int[] nums)
    {
        var sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 2)
            {
                sum = sum + nums[i];
            }

        }
        if (sum == 8)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if the number of 1's is greater than the number of 4's
    /// 
    /// more14([1, 4, 1]) → true
    /// more14([1, 4, 1, 4]) → false
    /// more14([1, 1]) → true
    /// </summary>
    public bool More14(int[] nums)
    {
        var count1 = 0;
        var count4 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count1++;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 4)
            {
                count4++;
            }
        }
        if (count1 > count4)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Given a number n, create and return a new int array of length n, containing the numbers
    /// 0, 1, 2, ... n-1. The given n may be 0, in which case just return a length 0 array. You do
    /// not need a separate if-statement for the length-0 case; the for-loop should naturally
    /// execute 0 times in that case, so it just works.
    /// 
    /// fizzArray(4) → [0, 1, 2, 3]
    /// fizzArray(1) → [0]
    /// fizzArray(10) → [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
    /// </summary>
    public int[] FizzArray(int n)
    {
        int[] fizzarr = new int[n];
        for (var i = 0; i < n; i++)
        {
            fizzarr[i] = i;
        }

        return fizzarr;
    }

    /// <summary>
    /// Given an array of ints, return true if every element is a 1 or a 4.
    /// 
    /// only14([1, 4, 1, 4]) → true
    /// only14([1, 4, 2, 4]) → false
    /// only14([1, 1]) → true
    /// </summary>
    public bool Only14(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 1 && nums[i] != 4)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Given a number n, create and return a new string array of length n, containing the strings
    /// "0", "1" "2" .. through n-1. N may be 0, in which case just return a length 0 array. Note:
    /// String.valueOf(xxx) will make the String form of most types.
    /// 
    /// fizzArray2(4) → ["0", "1", "2", "3"]
    /// fizzArray2(10) → ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]
    /// fizzArray2(2) → ["0", "1"]
    /// </summary>
    public string[] FizzArray2(int nums)
    {
        string[] fizzarr2 = new string[nums];
        for (var i = 0; i < nums; i++)
        {
            fizzarr2[i] = Convert.ToString(i);
        }

        return fizzarr2;
    }

    /// <summary>
    /// Given an array of ints, return true if it contains no 1's or it contains no 4's.
    /// 
    /// no14([1, 2, 3]) → true
    /// no14([1, 2, 3, 4]) → false
    /// no14([2, 3, 4]) → true
    /// </summary>
    public bool No14(int[] nums)
    {
        var one = 0;
        var four = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                one++;
            }
            if (nums[i] == 4)
            {
                four++;
            }
        }
        if (one > 0 && four > 0)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// We'll say that a value is "everywhere" in an array if for every pair of adjacent elements in
    /// the array, at least one of the pair is that value. Return true if the given value is everywhere
    /// in the array.
    /// 
    /// isEverywhere([1, 2, 1, 3], 1) → true
    /// isEverywhere([1, 2, 1, 3], 2) → false
    /// isEverywhere([1, 2, 1, 3, 4], 1) → false
    /// </summary>
    public bool IsEverywhere(int[] nums, int val)
    {
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != val && nums[i - 1] != val)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Given an array of ints, return true if the array contains a 2 next to a 2 or a 4 next to a 4,
    /// but not both.
    /// 
    /// either24([1, 2, 2]) → true
    /// either24([4, 4, 1]) → true
    /// either24([4, 4, 1, 2, 2]) → false
    /// </summary>
    public bool Either24(int[] nums)
    {
        var is22 = false;
        var is44 = false;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 2 && nums[i - 1] == 2)
            {
                is22 = true;
            }
        }
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 4 && nums[i - 1] == 4)
            {
                is44 = true;
            }
        }

        if (is22 && is44)
        {
            return false;
        }
        else if ((is22 && !is44) || (!is22 && is44))
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Given arrays nums1 and nums2 of the same length, for every element in nums1, consider
    /// the corresponding element in nums2 (at the same index). Return the count of the number
    /// of times that the two elements differ by 2 or less, but are not equal.
    /// 
    /// matchUp([1, 2, 3], [2, 3, 10]) → 2
    /// matchUp([1, 2, 3], [2, 3, 5]) → 3
    /// matchUp([1, 2, 3], [2, 3, 3]) → 2
    /// </summary>
    public int MatchUp(int[] nums1, int[] nums2)
    {
        int count = 0;
        for (var i = 0; i < nums1.Length; i++)
        {
            if (nums1[i] - nums2[i] != 0 && Math.Abs(nums1[i] - nums2[i]) <= 2)
            {
                count = count + 1;
            }
        }
        return count;
    }

    /// <summary>
    /// Given an array of ints, return true if the array contains two 7's next to each other, or there
    /// are two 7's separated by one element, such as with {7, 1, 7}.
    /// 
    /// has77([1, 7, 7]) → true
    /// has77([1, 7, 1, 7]) → true
    /// has77([1, 7, 1, 1, 7]) → false
    /// </summary>
    public bool Has77(int[] nums)
    {
        for (var i = 2; i < nums.Length; i++)
        {
            if ((nums[i] == 7 && nums[i - 1] == 7) || (nums[i] == 7 && nums[i - 2] == 7) || (nums[i - 1] == 7 && nums[i - 2] == 7))
            {
                return true;

            }
        }
        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in
    /// the array.
    /// 
    /// has12([1, 3, 2]) → true
    /// has12([3, 1, 2]) → true
    /// has12([3, 1, 4, 5, 2]) → true
    /// </summary>
    public bool Has12(int[] nums)
    {

        int one = Array.IndexOf(nums, 1);
        //int two = Array.IndexOf(nums, 2);
        //if (one == -1 || two == -1)
        //{
        //    return false;
        //}
        //if (one < two)
        //{
        //    return true;
        //}
        if (one == -1)
        {
            return false;
        }
        for (var i = one; i < nums.Length; i++)
        {
            if (nums[i] == 2)
            {
                return true;
            }
        }


        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if the array contains either 3 even or 3 odd values all
    /// next to each other.
    /// 
    /// modThree([2, 1, 3, 5]) → true
    /// modThree([2, 1, 2, 5]) → false
    /// modThree([2, 4, 2, 5]) → true
    /// </summary>
    public bool ModThree(int[] nums)
    {
        int countEven = 1;
        int countOdd = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0 && nums[i - 1] % 2 == 0)
            {
                countEven++;
            }
        }
        if (countEven >= 3)
        {
            return true;
        }
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0 && nums[i - 1] % 2 != 0)
            {
                countOdd++;
            }
        }
        if (countOdd >= 3)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if the value 3 appears in the array exactly 3 times, and
    /// no 3's are next to each other.
    /// 
    /// haveThree([3, 1, 3, 1, 3]) → true
    /// haveThree([3, 1, 3, 3]) → false
    /// haveThree([3, 4, 3, 3, 4]) → false
    /// </summary>
    public bool HaveThree(int[] nums)
    {
        int countThree = 0;
        if (nums[0] == 3)
        {
            countThree = 1;
        }

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 3 && nums[i - 1] != 3)
            {
                countThree++;
            }
        }
        if (countThree == 3)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if every 2 that appears in the array is next to another 2.
    /// 
    /// twoTwo([4, 2, 2, 3]) → true
    /// twoTwo([2, 2, 4]) → true
    /// twoTwo([2, 2, 4, 2]) → false
    /// </summary>
    public bool TwoTwo(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return false;
        }
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 2 && (i == 0 || nums[i - 1] != 2) && (i == (nums.Length - 1) || nums[i + 1] != 2))
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Return true if the group of N numbers at the start and end of the array are the same. For
    /// example, with {5, 6, 45, 99, 13, 5, 6}, the ends are the same for n=0 and n=2, and false
    /// for n=1 and n=3. You may assume that n is in the range 0..nums.length inclusive.
    /// 
    /// sameEnds([5, 6, 45, 99, 13, 5, 6], 1) → false
    /// sameEnds([5, 6, 45, 99, 13, 5, 6], 2) → true
    /// sameEnds([5, 6, 45, 99, 13, 5, 6], 3) → false
    /// </summary>
    public bool SameEnds(int[] nums, int val)
    {
        for (var i = 0; i < val; i++)
        {
            if (nums[i] != nums[nums.Length - val + i])
            {
                return false;
            }

        }
        return true;
    }

    /// <summary>
    /// Return true if the array contains, somewhere, three increasing adjacent numbers like ....
    /// 4, 5, 6, ... or 23, 24, 25.
    /// 
    /// tripleUp([1, 4, 5, 6, 2]) → true
    /// tripleUp([1, 2, 3]) → true
    /// tripleUp([1, 2, 4]) → false
    /// </summary>
    public bool TripleUp(int[] nums)
    {
        for (var i = 2; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] + 1 && nums[i - 1] == nums[i - 2] + 1)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Given start and end numbers, return a new array containing the sequence of integers
    /// rom start up to but not including end, so start=5 and end=10 yields {5, 6, 7, 8, 9}. The
    /// end number will be greater or equal to the start number. Note that a length-0 array is
    /// valid.
    /// 
    /// fizzArray3(5, 10) → [5, 6, 7, 8, 9]
    /// fizzArray3(11, 18) → [11, 12, 13, 14, 15, 16, 17]
    /// fizzArray3(1, 3) → [1, 2]
    /// </summary>
    public int[] FizzArray3(int start, int end)
    {
        int[] fizzAr = new int[end - start];
        for (var i = start; i < end; i++)
        {
            fizzAr[i - start] = i;
        }

        return fizzAr;
    }

    /// <summary>
    /// Return an array that is "left shifted" by one -- so {6, 2, 5, 3} returns {2, 5, 3, 6}. You
    /// may modify and return the given array, or return a new array.
    /// 
    /// shiftLeft([6, 2, 5, 3]) → [2, 5, 3, 6]
    /// shiftLeft([1, 2]) → [2, 1]
    /// shiftLeft([1]) → [1]
    /// </summary>
    public int[] ShiftLeft(int[] nums)
    {
        int[] shiftL = new int[nums.Length];
        if (nums.Length > 0)
        {
            shiftL[nums.Length - 1] = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                shiftL[i] = nums[i + 1];
            }
        }
        return shiftL;
    }

    /// <summary>
    /// For each multiple of 10 in the given array, change all the values following it to be that
    /// multiple of 10, until encountering another multiple of 10. So {2, 10, 3, 4, 20, 5} yields {2,
    /// 10, 10, 10, 20, 20}.
    /// 
    /// tenRun([2, 10, 3, 4, 20, 5]) → [2, 10, 10, 10, 20, 20]
    /// tenRun([10, 1, 20, 2]) → [10, 10, 20, 20]
    /// tenRun([10, 1, 9, 20]) → [10, 10, 10, 20]
    /// </summary>
    public int[] TenRun(int[] nums)
    {
        int? value = null;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 10 == 0)
            {
                value = nums[i];
            }
            else if (value.HasValue)
            {
                nums[i] = value.Value;
            }
        }
        return nums;
    }

    /// <summary>
    /// Given a non-empty array of ints, return a new array containing the elements from the
    /// original array that come before the first 4 in the original array. The original array will
    /// contain at least one 4. Note that it is possible to create an array of length 0.
    /// 
    /// pre4([1, 2, 4, 1]) → [1, 2]
    /// pre4([3, 1, 4]) → [3, 1]
    /// pre4([1, 4, 4]) → [1]
    /// </summary>
    public int[] Pre4(int[] nums)
    {
        int four = Array.IndexOf(nums, 4);
        int[] preFour = new int[four];

        for (var i = 0; i < four; i++)
        {
            preFour[i] = nums[i];
        }

        return preFour;
    }

    /// <summary>
    /// Given a non-empty array of ints, return a new array containing the elements from the
    /// original array that come after the last 4 in the original array. The original array will contain
    /// at least one 4. Note that it is possible to create an array of length 0.
    /// 
    /// post4([2, 4, 1, 2]) → [1, 2]
    /// post4([4, 1, 4, 2]) → [2]
    /// post4([4, 4, 1, 2, 3]) → [1, 2, 3]
    /// </summary>
    public int[] Post4(int[] nums)
    {
        int poFour = (Array.LastIndexOf(nums, 4)) + 1;
        int[] poFourInd = new int[nums.Length - poFour];

        for (var i = poFour; i < nums.Length; i++)
        {
            poFourInd[i - poFour] = nums[i];
        }
        return poFourInd;
    }

    /// <summary>
    /// We'll say that an element in an array is "alone" if there are values before and after it, and
    /// those values are different from it. Return a version of the given array where every instance
    /// of the given value which is alone is replaced by whichever value to its left or right is larger.
    /// 
    /// notAlone([1, 2, 3], 2) → [1, 3, 3]
    /// notAlone([1, 2, 3, 2, 5, 2], 2) → [1, 3, 3, 5, 5, 2]
    /// notAlone([3, 4], 3) → [3, 4]
    /// </summary>
    public int[] NotAlone(int[] nums, int val)
    {
        int[] arrr = new int[nums.Length];
        if (nums.Length > 2)
        {
            for (var i = 1; i < nums.Length - 1; i++)
            {
                arrr[0] = nums[0];
                arrr[nums.Length - 1] = nums[nums.Length - 1];
                arrr[i] = nums[i];
                if (nums[i] == val && nums[i - 1] != val && nums[i + 1] != val)
                {
                    arrr[i] = Math.Max(nums[i - 1], nums[i + 1]);
                }
            }
        }
        else
        {
            arrr = nums;
        }

        return arrr;
    }

    /// <summary>
    /// Return an array that contains the exact same numbers as the given array, but rearranged
    /// so that all the zeros are grouped at the start of the array. The order of the non-zero
    /// numbers does not matter. So {1, 0, 0, 1} becomes {0 ,0, 1, 1}. You may modify and
    /// return the given array or make a new array.
    /// 
    /// zeroFront([1, 0, 0, 1]) → [0, 0, 1, 1]
    /// zeroFront([0, 1, 1, 0, 1]) → [0, 0, 1, 1, 1]
    /// zeroFront([1, 0]) → [0, 1]
    /// </summary>
    public int[] ZeroFront(int[] nums)
    {
        Array.Sort(nums, (a1, a2) => (a1 == 0 ? 0 : 1).CompareTo(a2 == 0 ? 0 : 1));

        return nums;
    }

    /// <summary>
    /// Return a version of the given array where all the 10's have been removed. The remaining
    /// elements should shift left towards the start of the array as needed, and the empty spaces
    /// a the end of the array should be 0. So {1, 10, 10, 2} yields {1, 2, 0, 0}. You may modify
    /// and return the given array or make a new array.
    /// 
    /// withoutTen([1, 10, 10, 2]) → [1, 2, 0, 0]
    /// withoutTen([10, 2, 10]) → [2, 0, 0]
    /// withoutTen([1, 99, 10]) → [1, 99, 0]
    /// </summary>
    public int[] WithoutTen(int[] nums)
    {
        int[] newarr = new int[nums.Length];
        var index = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 10 != 0)
            {
                newarr[index++] = nums[i];
            }

        }

        return newarr;
    }

    /// <summary>
    /// Return a version of the given array where each zero value in the array is replaced by the
    /// largest odd value to the right of the zero in the array. If there is no odd value to the right
    /// of the zero, leave the zero as a zero.
    /// 
    /// zeroMax([0, 5, 0, 3]) → [5, 5, 3, 3]
    /// zeroMax([0, 4, 0, 3]) → [3, 4, 3, 3]
    /// zeroMax([0, 1, 0]) → [1, 1, 0]
    /// </summary>
    public int[] ZeroMax(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                var value = 0;
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] % 2 == 1 && nums[j] > value)
                    {
                        value = nums[j];
                    }
                }

                nums[i] = value;
            }
        }

        return nums;
    }

    /// <summary>
    /// Return an array that contains the exact same numbers as the given array, but rearranged
    /// so that all the even numbers come before all the odd numbers. Other than that, the
    /// numbers can be in any order. You may modify and return the given array, or make a new
    /// array.
    /// 
    /// evenOdd([1, 0, 1, 0, 0, 1, 1]) → [0, 0, 0, 1, 1, 1, 1]
    /// evenOdd([3, 3, 2]) → [2, 3, 3]
    /// evenOdd([2, 2, 2]) → [2, 2, 2]
    /// </summary>
    public int[] EvenOdd(int[] nums)
    {
        Array.Sort(nums, (i1, i2) => (i1 % 2).CompareTo(i2 % 2));

        return nums;
    }

    /// <summary>
    /// This is slightly more difficult version of the famous FizzBuzz problem which is sometimes
    /// given as a first problem for job interviews. Consider the series
    /// of numbers beginning at start and running up to but not including end, so for example
    /// start=1 and end=5 gives the series 1, 2, 3, 4. Return a new String[] array containing the
    /// string form of these numbers, except for multiples of 3, use "Fizz" instead of the number,
    /// for multiples of 5 use "Buzz", and for multiples of both 3 and 5 use "FizzBuzz".
    /// This version is a little more complicated than the usual version since you have to
    /// allocate and index into an arrayinstead of just printing, and we vary the start/end instead of just always doing 1..100.
    /// 
    /// fizzBuzz(1, 6) → ["1", "2", "Fizz", "4", "Buzz"]
    /// fizzBuzz(1, 8) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7"]
    /// fizzBuzz(1, 11) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"]
    /// </summary>
    public string[] FizzBuzz(int start, int end)
    {
        var arr = new string[end - start];

        for (var i = start; i < end; i++)
        {
            if (i % 15 == 0)
            {
                arr[i - start] = "FizzBuzz";
            }
            else if (i % 5 == 0)
            {
                arr[i - start] = "Buzz";
            }
            else if (i % 3 == 0)
            {
                arr[i - start] = "Fizz";
            }
            else
            {
                arr[i - start] = i.ToString();
            }
        }

        return arr;


    }
}