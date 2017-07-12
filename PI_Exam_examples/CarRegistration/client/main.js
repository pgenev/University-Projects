function generateRegNumber(){
	var carRegNumber = "E"
	var randNumber = "";
	do{
		randNumber = Math.ceil(Math.random()*10000);
	} while (randNumber < 1000);
	return carRegNumber + randNumber;
}

Template.carReg.events({
	'click .register' : function(event) {
		event.preventDefault();

		document.getElementById("showRegCar").innerHTML = "";

		var brand = $('#brand').val();
		var model = $('#model').val();
		var year = $('#year').val();
		var volume = $('#engineVolume').val();
		var carNumber = generateRegNumber();

		if (!brand || !model || !year || !volume) {
			alert("Не сте въвели стойност в някое от полетата!");
			return;
		}

		carNumber = "E5591";
		var allCars = Cars.find().fetch();

		for(var i=0; i < allCars.length; ++i)
		{
			if (allCars[i].carNumber === carNumber) {
				alert("Вече има кола с такъв регистрационен номер!");
				return;
			}
		}

		var car = {
			brand: brand,
			model: model,
			year: year,
			volume: volume,
			carNumber: carNumber
		}

		Cars.insert(car);
		
		document.getElementById("showRegCar").innerHTML += "Марка: " + brand + "<br>" + " Модел: " + model + "<br>" + " Година: " + year + "<br>" + " Обем на двигателя: " + volume + "<br>";

		document.getElementById("showRegCar").innerHTML += "Номер: " + carNumber;
	}
});