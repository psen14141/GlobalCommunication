function ShowNotification(message, title = 'Notification') {

	swal({
		title: title,
		text: message,
		icon: "error",
		buttons: {
			confirm: {
				className: 'btn btn-primary'
			}
		}
	});
	var content = {};

	content.message = message;
	content.title = title;
	content.icon = 'la la-bell';
	content.url = '#';
	/*content.target = '_blank';*/

	$.notify(content, {
		type: 'primary',
		placement: {
			from: 'top',
			align: 'right'
		},
		time: 1000,
	});
}

function IsFilled(id, elementName = "Form Item", message = "") {
    let originalName = id;
    id = "#" + id;
	if ($(id).length == 0) {

		console.log(id + ": element not exist");
		if (message == "") {
			ShowNotification(elementName + " cannot find", elementName);
		}
		else {
			ShowNotification(message, elementName);
        }
		
        return false;
    }

    if ($(id).val() != "") {
		
        return true;
	}

	console.log(id + ": is empty");
	if (message == "") {
		ShowNotification(elementName + " cannot empty", elementName);
	}
	else {
		ShowNotification(message, elementName);
	}
    return false;
}

function MaxCharactor(id, lenght, elementName = "Form Item") {
	if (IsFilled(id, elementName)) {
		id = "#" + id;
		if ($(id).val().length > lenght) {
			ShowNotification("Exceed the maximum length", elementName);
			console.log(id + ": too long :" + lenght );
			return false;
		}
		else {
			return true;
        }

	}
	return false
}

function MaxFileSize(id, size, elementName = "Form Item") {
	if (IsFilled(id, elementName)) {
		id = "#" + id;
		let input = $(id);
		if (!input.files || !input.files[0]) {
			ShowNotification("Files not found ", elementName);
			console.log(id + ": Files not found :" + lenght);
			return false;
		}
		let file = input.files[0];
		if (file.size > size) {
			ShowNotification("Exceed the maximum file size", elementName);
			console.log(id + ": Exceed the maximum file size :" + size);
			return false;
		}
		else {
			return true;
		}

	}
	return false
}