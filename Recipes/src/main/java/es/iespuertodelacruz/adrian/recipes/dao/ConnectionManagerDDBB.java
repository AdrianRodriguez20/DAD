/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

import org.apache.commons.dbcp.BasicDataSource;

/**
 *
 * @author Adrián Rodríguez Fuentes
 */
public class ConnectionManagerDDBB {

    String jdbcUrl;
    String usuario;
    String clave;
    BasicDataSource basicDataSource;

    public ConnectionManagerDDBB(String ddbb, String nombreUsuario, String password) {
        jdbcUrl = "jdbc:mysql://localhost/" + ddbb + "?serverTimezone=UTC";
        usuario = nombreUsuario;
        clave = password;
        cargarDriverMysql();
        basicDataSource = new BasicDataSource();
        basicDataSource.setDriverClassName("com.mysql.jdbc.Driver");
        basicDataSource.setUrl(jdbcUrl);
        basicDataSource.setUsername(nombreUsuario);
        basicDataSource.setPassword(password);

    }

    public Connection getConnection() {

        Connection con = null;
        try {
            con = basicDataSource.getConnection();
        } catch (SQLException ex) {
            System.exit(1);
        }
        return con;
    }

    private static void cargarDriverMysql() {
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
        } catch (ClassNotFoundException ex) {
            System.err.println("no carga el driver");
            System.exit(1);
        }
    }

}
