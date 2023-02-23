// Получить от пользователя два числа и вывести в диалоговое окно сумму значений, 
// которые ввел пользователь, вывод должен выглядеть так (пример): 
// Результат сложения чисел 5 и 2 равен 7.

const a = Number.parseFloat(prompt("Введите первое число: "));
const b = Number.parseFloat(prompt("Введите второе число: "));

function sumTwoNum(num1, num2) {
    //const sum = num1 + num2;
    //return sum;
    return num1 + num2;
}

alert(`Результат сложения чисел ${a} и ${b} равен ${sumTwoNum(a, b)}`);