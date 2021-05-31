const express = require('express');
const app = express();

app.get('/sit', (req, res) => {
	console.log('walk', new Date());
	res.send(true);
});

app.get('/stand', (req, res) => {
	console.log('stand', new Date());
	res.send(true);
});

app.post('/walk', (req, res) => {
	console.log('walk', new Date());
	res.send(true);
});

app.post('/walkForward', (req, res) => {
	console.log('walkForward', new Date());
	res.send(true);
});

app.listen(1234, () => {
	console.log('listening on port 1234');
});
