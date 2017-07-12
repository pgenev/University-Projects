Template.searchCar.helpers({
	'carsBrandList' : function(){
		return Cars.find();
	}
});

Template.searchCar.events({
	'click .search': function(){
		
		document.getElementById("showCars").innerHTML = "";
		var brand = $('option:selected').val();
		var carCondition = $('#checkCondition').is(':checked');
		if(!brand)
		{
			alert('Моля изберете модела на автомобила!');
		}

		chosenCars = Cars.find({brand: brand, used: carCondition}).fetch();

		if(chosenCars.length == 0)
		{
			document.getElementById("showCars").innerHTML = "Няма намерен автомобил!";
		}
		else
		{
			chosenCars.forEach(function(car) {
				 document.getElementById("showCars").innerHTML += String(car.brand + " " + car.model);
				 document.getElementById("showCars").innerHTML += '<br>';
			});
		}
	}
});