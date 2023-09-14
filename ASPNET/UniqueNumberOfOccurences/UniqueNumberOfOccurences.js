/**
 * @param {number[]} arr
 * @return {boolean}
 */
var uniqueOccurrences = function(arr) 
{
  let map1 = new Map();

  map1.set(arr[0], 1);

  for(let i = 1; i < arr.length; i++)
  {
    if(map1.has(arr[i]))
    {
      map1.set(arr[i], map1.get(arr[i]) + 1);
    }

    if(!map1.has(arr[i]))
    {
      map1.set(arr[i], 1)
    }
  }    

  let checkArray = [];
  
  for(const value of map1.values())
  {
    if(checkArray.includes(value))
    {
        return false;
    }
    else
    {
      checkArray.push(value);
    }
  }

  return true;
};