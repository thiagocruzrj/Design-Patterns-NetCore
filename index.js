const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');

const config = require('./config');
const app = express();

mongoose.Promise = global.Promise;
mongoose.connect(config.dbUrl, {
    useNewUrlParser: true
}).then(() =>{
    console.log(`Connected to MongoDB at ${config.dbUrl}`);
})
// parse of requests with content-type using application/json
app.use(bodyParser.json())


const usersRoute = require('./routes/users');
//http://localhost:3001/users/....
app.use('/users', usersRoute)

app.get('/', (req, res) => {
    res.json({
        message: "Go to the users route, (/users)"
    })
})
const PORT = 3001;
app.listen(PORT, () =>{
    console.log(config.dbUrl)
    console.log(`'API server running on Port: ${PORT}`);
})