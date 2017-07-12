Template.addRecords.events({
	'click .save' : function(event) {
		event.preventDefault();

		document.getElementById('showRecord').innerHTML = "";

		var title = $('[name=title]').val();
		var author = $('[name=author]').val();
		var words = $('[name=words]').val();

		if(!title || !author || !words) 
		{
			alert("Моля попълнете всички полета!");
			return;
		}

		var dbObj = {
			title: title,
			author: author,
			words: words
		};

		Conf.insert(dbObj);

		document.getElementById('showRecord').innerHTML = title + " " + author + " " + words;
	}
});