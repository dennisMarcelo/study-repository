const Sequelize = require("sequelize");

//conexão
const sequelize = new Sequelize("postapp", "root", "PPK24.bat",{
    host: "localhost",
    dialect: "mysql"
});

module.exports = {
    Sequelize: Sequelize,
    sequelize: sequelize
}