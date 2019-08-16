

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
const indexCopy=(arr,index)=>{
	if(arr[index]===undefined)return;
	if(arr.length ===1){
		console.log("item:"+ arr[index])
		animals[arr[index].day-1] = arr[index]
		return;
	}
	let halfWayThough = Math.ceil(arr.length / 2)
	let arrayFirstHalf = arr.slice(0, halfWayThough);
	let arraySecondHalf = arr.slice(halfWayThough, arr.length);
	
	indexCopy(arrayFirstHalf,arrayFirstHalf.length-1)
	indexCopy(arraySecondHalf,arraySecondHalf.length-1)
	
}

indexCopy(obj,obj.length-1)
console.log(animals)
