/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.controller;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.chart.PieChart;
import javafx.scene.chart.StackedBarChart;

/**
 * FXML Controller class
 *
 * @author Adrián Rodríguez Fuentes
 */
public class StatisticsController implements Initializable {

    @FXML
    private PieChart graphicCalories;
    @FXML
    private StackedBarChart<?, ?> graphicTypeRecipe;

    /**
     * Initializes the controller class.
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    
    
}
