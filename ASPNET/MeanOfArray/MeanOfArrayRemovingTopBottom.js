/**
 * @param {number[]} arr
 * @return {number}
 */
var trimMean = function(arr)
{

  let arrMax = arr[0];
  let arrMin = arr[0];

  let bottom5pct = 1/20;
  let top5pct = 19/20;

  let map1 = new Map();
  let resultLength = 0;
  let resultTotal = 0;

  for(let i = 0; i < arr.length; i++)
  {
    if(arrMax < arr[i])
    {
      arrMax = arr[i];
    }
    if(arrMin > arr[i])
    {
      arrMin = arr[i];
    }

    map1.set(i, arr[i])
  }

  for(let i = 0; i < arr.length; i++)
  {
    if(arrMax * bottom5pct < map1.get(i))
    {
      continue;
    }
    if((arrMax * top5pct < map1.get(i)))
    {
      continue;
    }
    else
    {
      resultTotal += (map1.get(i));
      console.log(map1.get(i));
      resultLength += 1;
    }
  }
  
  return resultTotal / resultLength;

};


testArr = [1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3];

let result = trimMean(testArr)

console.log(result)