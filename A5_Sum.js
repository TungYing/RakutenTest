//加法器原理
let a = 1;
let b = 2;
let sum = 3;

function add(a,b){
  if(b == 0) return a;
  let sum = a ^ b;
  let carry = (a & b) << 1;
  return add(sum,carry);
  
}

console.log(add(a,b)===sum);