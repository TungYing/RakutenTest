
let testNum1 = 16;
let testNum2 = 14;
let testResult1 = true;
let testResult2 = false;

function IsPerfectSquare(number){
  if(Number(number) == 1)return true;
  let length = Number(number / 2); 
  for(let i=0;i<=length;i++){
    if(i*i == Number(number))
      return true;
  }
  return false;
}

console.log(IsPerfectSquare(testNum1) === testResult1);
console.log(IsPerfectSquare(testNum2) === testResult2);
