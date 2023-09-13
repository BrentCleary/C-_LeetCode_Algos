/**
 * @param {number[]} flowerbed
 * @param {number} n
 * @return {boolean}
 */
var canPlaceFlowers = function(flowerbed, n) 
{

  // n == 0 is always true
  if(n == 0)
  {
    return true;
  }

  

  let flowerCounter = 0;

  // iterate over the flowerbed array
  let i = 0;
  while(i < flowerbed.length)
  {
    
    // middle of array
    if(i != flowerbed.length - 1 && flowerbed[i] == 0 && flowerbed[i+1] != 1 && flowerbed[i-1] != 1)
    {
      flowerCounter += 1;
      console.log("Adding middle flowerCounter at " + i);
      i++;
            if(i == flowerbed.length - 1)
      {
        console.log(i);
        break;
      }
    }

    // check the first index, and the second
    if(i == 0 && flowerbed[i] == 0 && flowerbed[1] != 1)
    {
      flowerCounter += 1;
      console.log("Adding start flowerCounter at " + i);
      i++;

      if(i == flowerbed.length - 1)
      {
        console.log(i);
        break;
      }
    }

    // check last index, and second to last
    if(i == flowerbed.length - 1 && flowerbed[i] == 0 && flowerbed[flowerbed.length - 2] != 1)
    {
      flowerCounter += 1;
      console.log("Adding end flowerCounter at " + i);

    }
    
    i++
  }

  if(flowerCounter >= n)
  {
    return true;
  }
  else
  {
    return false;
  }

};