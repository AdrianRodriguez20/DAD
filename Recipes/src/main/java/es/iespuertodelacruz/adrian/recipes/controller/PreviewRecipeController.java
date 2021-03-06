/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.controller;

import com.jfoenix.controls.JFXButton;
import de.jensd.fx.glyphs.fontawesome.FontAwesomeIconView;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.image.ImageView;

/**
 * FXML Controller class
 *
 * @author Adrián Rodríguez Fuentes
 */
public class PreviewRecipeController implements Initializable {

    @FXML
    private Label txtTitle;
    @FXML
    private Label txtPreparationTime;
    @FXML
    private Label txtAuthor;
    @FXML
    private Label txtNumberDiners;
    @FXML
    private Label txtTypeRecipe;
    @FXML
    private ImageView imgRecipe;
    @FXML
    private JFXButton btnViewMore;
    @FXML
    private Button btnDelete;
    @FXML
    private Button btnEdit;

    /**
     * Initializes the controller class.
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    
    
}
