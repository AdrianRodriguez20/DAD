/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.controller;

import com.jfoenix.controls.JFXTextArea;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.image.ImageView;
import javafx.scene.input.MouseEvent;

/**
 * FXML Controller class
 *
 * @author Adrián Rodríguez Fuentes
 */
public class RecipeController implements Initializable {

    @FXML
    private ImageView imgRecipe;
    @FXML
    private Label txtTitle;
    @FXML
    private Label txtAuthor;
    @FXML
    private Label txtNumberDiners;
    @FXML
    private Label txtPreparationTime;
    @FXML
    private Label txtTypeRecipe;
    @FXML
    private Label txtCalories;
    @FXML
    private JFXTextArea txtSteps;
    @FXML
    private JFXTextArea txtIngredients;
    @FXML
    private ImageView btnReturn;

    /**
     * Initializes the controller class.
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    

    @FXML
    private void Return(MouseEvent event) {
    }
    
}
