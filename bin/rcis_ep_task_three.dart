import 'dart:io';
import 'dart:math';
import 'dart:async';

void main() {

  //Задание 2
var numbers = File('C:/Users/Aydan/Desktop/nums.txt');
var a = numbers.readAsStringSync();


List<String> nums = a.split(" ");
print(nums);
for (int i = 0; i < nums.length; ++i) {
if (int.parse(nums[i]) % 2 == 0) {
nums.remove(nums[i]);
}
}
print(nums);
}
