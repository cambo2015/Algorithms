//a fun algorithm I made.
//Needed something fast to copy 
//database array into another array at
//a specified index.

//copies the obj arr data into
//the animals array at a specified
// index.
//the specified index is the day
//animals[obj[index].day] = obj[index]


var animals = new Array(30)
let obj = [
{
	day:1
},
{
	day:2
},
{
	day:6
},
{
	day:10
},
{
	day:12
}
]

const halve=(arr,index,resultFunc)=>{
	
	if(arr[index]===undefined)return;
	if(arr.length ===1){
		resultFunc(arr,index)
		return;
	}
	let halfArr = Math.ceil(arr.length / 2)
	let arrFirstHalf = arr.slice(0, halfArr);
	let arrSecondHalf = arr.slice(halfArr, arr.length);
	
	halve(arrFirstHalf,arrFirstHalf.length-1,resultFunc)
	halve(arrSecondHalf,arrSecondHalf.length-1,resultFunc)
}

halve(obj,obj.length-1,(arr,index)=>{
	animals[arr[index].day-1] = arr[index]
})
console.log(animals)
