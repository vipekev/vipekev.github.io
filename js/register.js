let name = document.querySelector('#name');
let password = document.querySelector('#password');
let email = document.querySelector('#email');
let submit = document.querySelector('#submit');

let users = {};

function User(name, password, email) {
	this.name = name;
	this.password = password;
	this.email = email;
}

function createId(users) {
	return Object.keys(users).length;
}

submit.addEventListener('click', () => {
	const nameUser = name.value;
	const passwordUser = password.value;
	const emailUser = email.value;
	
	const user = new User(nameUser, passwordUser, emailUser);
	
	const userId = 'User' + createId(users);
	users[userId] = user;
	
	console.log(users);
	
	alert(`${nameUser}, вы успешно прошли регистрацию!`);
})


