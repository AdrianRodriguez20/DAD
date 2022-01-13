/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.dao;

import es.iespuertodelacruz.adrian.recipes.model.Recipe;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * @author Adrián Rodríguez Fuentes
 */
public class RecipeDAO implements Crud<Recipe, String> {

    ConnectionManagerDDBB gc;

    public RecipeDAO() {
        this.gc = new ConnectionManagerDDBB("recipes", "admin", "1q2w3e4r");
    }

    @Override
    public Recipe save(Recipe dao) {
        String sql = "INSERT INTO recipe (title, author, typeRecipe, ingredients, steps, numberDiners, preparationTime, calories, image) VALUES (?,?,?,?,?,?,?,?,?)";
        Recipe recipe = null;
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, dao.getTitle());
            pstmt.setString(2, dao.getAuthor());
            pstmt.setString(3, dao.getTypeRecipe());
            pstmt.setString(4, String.join(",", dao.getIngredients()));
            pstmt.setString(5, String.join(",", dao.getSteps()));
            pstmt.setInt(6, dao.getNumberDiners());
            pstmt.setInt(7, dao.getPreparationTime());
            pstmt.setDouble(8, dao.getCalories());
            pstmt.setString(9, dao.getImage());
            int affectedRows = pstmt.executeUpdate();
            if (affectedRows > 0) {
                recipe = dao;
            }
        } catch (SQLException e) {
            System.out.println("Se ha producido un error almacenando en la BBDD:" + e.getMessage());
        }
        return recipe;

    }

    @Override
    public Recipe findById(String id) {
        String sql = " SELECT title, author, typeRecipe, ingredients, steps, numberDiners, preparationTime, calories, image FROM recipe WHERE title  = ?";
        Recipe recipe = null;
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, id);
            ResultSet resultSet = pstmt.executeQuery();
            if (resultSet.next()) {
                recipe = new Recipe(resultSet.getString(1),
                        resultSet.getString(2),
                        resultSet.getString(3),
                        Arrays.asList(resultSet.getString(4).split(",")),
                        Arrays.asList(resultSet.getString(5).split(",")),
                        resultSet.getInt(6),
                        resultSet.getInt(7),
                        resultSet.getDouble(8),
                        resultSet.getString(9)
                );
            }
        } catch (SQLException ex) {
            Logger.getLogger(UserDAO.class.getName()).log(Level.SEVERE, null, ex);
        }

        return recipe;
    }

    @Override
    public boolean update(Recipe dao) {
        String sql = "UPDATE recipe SET  author = ?, typeRecipe = ?, ingredients = ?, steps = ?, numberDiners = ?, preparationTime = ?, calories = ?, image = ? WHERE title = ?";
        boolean updated = false;
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, dao.getAuthor());
            pstmt.setString(2, dao.getTypeRecipe());
            pstmt.setString(3, String.join(",", dao.getIngredients()));
            pstmt.setString(4, String.join(",", dao.getSteps()));
            pstmt.setInt(5, dao.getNumberDiners());
            pstmt.setInt(6, dao.getPreparationTime());
            pstmt.setDouble(7, dao.getCalories());
            pstmt.setString(8, dao.getImage());
            pstmt.setString(9, dao.getTitle());
            int affectedRows = pstmt.executeUpdate();
            if (affectedRows > 0) {
                updated = true;

            }

        } catch (SQLException e) {
            System.out.println("Se ha producido un error al actualizar en la BBDD:" + e.getMessage());
        }
        return updated;
    }

    @Override
    public boolean delete(String id) {
        String sql = "DELETE FROM recipe WHERE title = ?";
        boolean deleted = false;
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, id);
            int affectedRows = pstmt.executeUpdate();
            if (affectedRows > 0) {
                deleted = true;

            }
        } catch (SQLException e) {
            System.out.println("Se ha producido un error al borrar en la BBDD:" + e.getMessage());
        }
        return deleted;
    }

    @Override
    public ArrayList<Recipe> findAll() {
        String sql = " SELECT title, author, typeRecipe, ingredients, steps, numberDiners, preparationTime, calories, image FROM recipe";
        ArrayList<Recipe> recipes = new ArrayList<>();
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            ResultSet resultSet = pstmt.executeQuery();
            try {
                while (resultSet.next()) {
                    recipes.add(new Recipe(resultSet.getString(1),
                            resultSet.getString(2),
                            resultSet.getString(3),
                            Arrays.asList(resultSet.getString(4).split(",")),
                            Arrays.asList(resultSet.getString(5).split(",")),
                            resultSet.getInt(6),
                            resultSet.getInt(7),
                            resultSet.getDouble(8),
                            resultSet.getString(9)
                    ));
                }
            } catch (SQLException sqlException) {
                System.out.println("Se ha producido un error transformando los datos de la consulta:" + sqlException.getMessage());

            }

        } catch (SQLException e) {
            System.out.println("Se ha producido un error realizando la consulta en la BBDD:" + e.getMessage());
        }

        return recipes;
    }

    public ArrayList<Recipe> findByTitle(String title){


        String sql = " SELECT title, author, typeRecipe, ingredients, steps, numberDiners, preparationTime, calories, image FROM recipe WHERE title LIKE ?";
        ArrayList<Recipe> recipes = new ArrayList<>();
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, title);
            ResultSet resultSet = pstmt.executeQuery();
            try {
                while (resultSet.next()) {
                    recipes.add(new Recipe(resultSet.getString(1),
                            resultSet.getString(2),
                            resultSet.getString(3),
                            Arrays.asList(resultSet.getString(4).split(",")),
                            Arrays.asList(resultSet.getString(5).split(",")),
                            resultSet.getInt(6),
                            resultSet.getInt(7),
                            resultSet.getDouble(8),
                            resultSet.getString(9)
                    ));
                }
            } catch (SQLException sqlException) {
                System.out.println("Se ha producido un error transformando los datos de la consulta:" + sqlException.getMessage());

            }

        } catch (SQLException e) {
            System.out.println("Se ha producido un error realizando la consulta en la BBDD:" + e.getMessage());
        }

        return recipes;
    }


    public HashMap<String, Integer> getTypeRecipeCount() {

        String sql = "SELECT typeRecipe, COUNT(*) FROM recipe GROUP BY typeRecipe";
        HashMap<String, Integer> typeRecipeCount = new HashMap<>();
        try (Connection conn = gc.getConnection();
                PreparedStatement pstmt = conn.prepareStatement(sql)) {
            ResultSet resultSet = pstmt.executeQuery();
            try {
                while (resultSet.next()) {
                    typeRecipeCount.put(resultSet.getString(1), resultSet.getInt(2));
                }
            } catch (SQLException sqlException) {
                System.out.println("Se ha producido un error transformando los datos de la consulta:" + sqlException.getMessage());

            }

        } catch (SQLException e) {
            System.out.println("Se ha producido un error realizando la consulta en la BBDD:" + e.getMessage());
        }

        return typeRecipeCount;
    }



}