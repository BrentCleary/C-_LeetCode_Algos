// 1491. Average Salary Excluding the Minimum and Maximum Salary
// Easy
// 2.2K
// 179
// Companies
// You are given an array of unique integers salary where salary[i] is the salary of the ith employee.

// Return the average salary of employees excluding the minimum and maximum salary. Answers within 10-5 of the actual answer will be accepted.


/**
 * @param {number[]} salary
 * @return {number}
 */
var average = function(salary)
{
    let minSal = salary[0];
    let maxSal = salary[0];
    let totalSal;


    for (let i = 0; i < salary.length; i++)
    {
      totalSal += salary[i];

      if(salary[i] < minSal)
      {
        minSal = salary[i]
      }

      if(salary[i] > maxSal)
      {
        maxSal = salary[i]
      }
    }



    solutionSal = (((totalSal - maxSal) - minSal) / (salary.length - 2))

    return solutionSal;
};