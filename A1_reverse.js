let testString = 'hello';
let expectString = 'olleh';

String.prototype.reverse=function(){
  return this.split("").reverse().join("");
}

console.log(testString.reverse() === expectString);

