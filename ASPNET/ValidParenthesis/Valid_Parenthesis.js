/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function(s) 
{

  let answerArray = []

  for(let i = 0; i < s.length; i++)
  {
    // Push all opening brackets
    if(s[i] == "(")
    {
      console.log("Pushing " + "(" + " index " + i)
      answerArray.push(s[i]);
    }
    if(s[i] == "[")
    {
      console.log("Pushing " + "[" + " index " + i)
      answerArray.push(s[i]);
    }
    if(s[i] == "{")
    {
      console.log("Pushing " + "{" + " index " + i)
      answerArray.push(s[i]);
    }

    // Check for a match on all closing brackets
    // Remove matching bracket from answer array if found

    // () Check
    if(s[i] == ")" && answerArray[answerArray.length-1] != "(")
    {
      console.log("Breaking at " + ")" + " index " + i)
      return false;
    }
    else if(s[i] == ")")
    {
      answerArray.pop();
    }

    // [] Check
    if(s[i] == "]" && answerArray[answerArray.length-1] != "[")
    {
      console.log("Breaking at " + "]" + " index " + i)
      return false;
    }
    else if(s[i] == "]")
    {
      answerArray.pop();
    }

    // {} Check
    if(s[i] == "}" && answerArray[answerArray.length-1] != "{")
    {
      console.log("Breaking at " + "}" + " index " + i)
      return false;
    }
    else if(s[i] == "}")
    {
      answerArray.pop();
    }
  }

  if(answerArray.length == 0)
  {
    return true;
  }
  else
  {
    return false;
  }

};