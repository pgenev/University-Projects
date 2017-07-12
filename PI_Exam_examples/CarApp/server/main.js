Meteor.startup(function() {
   
    var numberOfCars = Cars.find().count();

    if(numberOfCars == 0) 
    {
		var cars = [
			{
				brand: 'VW',
				model: 'MK4',
				used: true
			}, 
			{
				brand: 'Audi',
				model: 'A4',
				used: false
			}, 
			{
				brand: 'BMW',
				model: '725TDS',
				used: true
			},
			{
				brand: 'Audi',
				model: 'A3',
				used: true
			},
			{
				brand: 'Audi',
				model: 'R8',
				used: true
			}
		];

  		cars.forEach(function(car){
 			Cars.insert(car);
  		});
  	}
});
