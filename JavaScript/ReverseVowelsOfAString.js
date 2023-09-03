/**
 * @param {string} s
 * @return {string}
 */

var setMapTest = function(s)
{
  // intialize map
  const map1 = new Map();
  
  // vowel list for checking
  let vowels = "aeiouAEIOU";
  let count = 0;

  // for-loop to go over s
  for(let i = 0; i < s.length; i++)
  {
    const currentCharacter = s[i];

    if((vowels.includes(currentCharacter)))
    {
      map1.set(count, s[i])
      count += 1;
    }
  }

  return map1;
};


let testString = "Apples in outer space"

result = setMapTest(testString)

for(const [key, value] of result)
{
  console.log(`Key: ${key}, Value: ${value}`);
}



var reverseVowels = function(s)
{
  // intialize map
  const map2 = new Map();
  let newString = "";

  // vowel list for checking
  let vowels = "aeiouAEIOU";
  count = 0;

  // for-loop to go over s
  for(let i = 0; i < s.length; i++)
  {
    const currentCharacter = s[i];

    if((vowels.includes(currentCharacter)))
    {
      map2.set(count, s[i])
      count += 1;
    }
  }

  count -= 1;

  // Go backward over s and insert from back of map
  for(let i = 0; i < s.length; i++)
  {
    const currentCharacter = s[i];

    if((vowels.includes(currentCharacter)))
    {
      newString += map2.get(count);
      count -= 1;
    }
    else
    {
      newString += s[i]; 
    }
  }

  return newString;

};

let stringResult = reverseVowels(testString);

console.log(stringResult);