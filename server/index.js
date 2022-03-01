const express = require('express');
const cors = require('cors');
const dotEnv = require('dotenv');
const {Sequelize} = require('sequelize');
dotEnv.config();

const app = express();
const environment = process.env
const PORT = environment.PORT;


//Connect your database to the application
const sequelizeConnection = new Sequelize(environment.DATABASE_NAME,environment.USERNAME,environment.PASSWORD,{
    host: environment.HOST,
    dialect:'mssql',
    operatorsAliases: false,
})

//Starts the Server Application
app.listen(PORT, () => {
    console.log(`The server is running on port: ${PORT}`);

    sequelizeConnection.authenticate().then(result => {
        console.log('database connection worked!')
    }).catch(err => {
        console.log(err)
    })
})