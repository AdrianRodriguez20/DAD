/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.dao;

import es.iespuertodelacruz.adrian.recipes.model.User;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Adrián Rodríguez Fuentes
 */
public class UserDAO implements Crud<User, String> {

    ConnectionManagerDDBB gc;

    public UserDAO (){
       this.gc = new ConnectionManagerDDBB("recipes", "admin", "1q2w3e4r"); 
    }
    
    @Override
    public User save(User dao) {
        String sql = "INSERT INTO users (username, password, role ) VALUES(?,?,?)";
        User user = null;
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, dao.getUsername());
            pstmt.setString(2, dao.getPassword());
            pstmt.setString(3, dao.getRole());
            int filasAfectadas = pstmt.executeUpdate();
            if (filasAfectadas > 0) {
                user = new User(dao.getUsername(), dao.getPassword(), dao.getRole());
            }
        } catch (SQLException e) {
            System.out.println("Se ha producido un error almacenando en la BBDD:" + e.getMessage());
        }

        return user;
    }

    @Override
    public User findById(String id) {
        String sql = " SELECT username , password , role FROM users WHERE username = ?";
        User user = null;
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, id);
            ResultSet resultSet = pstmt.executeQuery();
            if (resultSet.next()) {
                user = new User(resultSet.getString(1), resultSet.getString(2), resultSet.getString(3));
            }
        } catch (SQLException ex) {
            Logger.getLogger(UserDAO.class.getName()).log(Level.SEVERE, null, ex);
        }

        return user;
    }

    @Override
    public boolean update(User dao) {
          String sql = "UPDATE users SET password = ? , role = ? WHERE username= ?";
           Boolean exito = false;
           
              try (Connection conn = gc.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(sql)) {
             pstmt.setString(1, dao.getPassword());
             pstmt.setString(2, dao.getRole());
             pstmt.setString(3, dao.getUsername());
            int filasAfectadas = pstmt.executeUpdate();
            if (filasAfectadas > 0) {

                exito = true;
            }

        } catch (SQLException e) {
            System.out.println("Se ha producido un error actualizando en la BBDD:" + e.getMessage());
        }

           return exito;
    }

    @Override
    public boolean delete(String id) {
        String sql = "DELETE FROM users  WHERE  username = ?";
        Boolean exito = false;
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, id);

            int filasAfectadas = pstmt.executeUpdate();
            if (filasAfectadas > 0) {
                exito = true;
            }

        } catch (SQLException e) {
            System.out.println("Se ha producido un error eliminando en la BBDD:" + e.getMessage());
        }

        return exito;
    }

    @Override
    public ArrayList<User> findAll() {

        String sql = " SELECT username , password , role FROM users";
        ArrayList<User> users = new ArrayList<>();
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            ResultSet resultSet = pstmt.executeQuery();
            try {
                while (resultSet.next()) {
                    users.add(new User(resultSet.getString(1), resultSet.getString(2), resultSet.getString(3)));
                }
            } catch (SQLException sqlException) {
                System.out.println("Se ha producido un error transformando los datos de la consulta:" + sqlException.getMessage());

            }

        } catch (SQLException e) {
            System.out.println("Se ha producido un error realizando la consulta en la BBDD:" + e.getMessage());
        }

        return users;
    }

}
