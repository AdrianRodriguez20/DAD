/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.model;

import java.util.List;

/**
 *
 * @author Adrián Rodríguez Fuentes
 */
public class Recipe {
    
   private String title;
   private String author;
   private String typeRecipe;
   private List<String> ingredients;
   private List<String> steps;
   private int numberDiners;
   private int preparationTime;
   private double calories;
   private String image;

    public Recipe() {
    }

    public Recipe(String title, String author, String typeRecipe, List<String> ingredients, List<String> steps, int numberDiners, int preparationTime, double calories, String image) {
        this.title = title;
        this.author = author;
        this.typeRecipe = typeRecipe;
        this.ingredients = ingredients;
        this.steps = steps;
        this.numberDiners = numberDiners;
        this.preparationTime = preparationTime;
        this.calories = calories;
        this.image = image;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getTypeRecipe() {
        return typeRecipe;
    }

    public void setTypeRecipe(String typeRecipe) {
        this.typeRecipe = typeRecipe;
    }

    public List<String> getIngredients() {
        return ingredients;
    }

    public void setIngredients(List<String> ingredients) {
        this.ingredients = ingredients;
    }

    public List<String> getSteps() {
        return steps;
    }

    public void setSteps(List<String> steps) {
        this.steps = steps;
    }

    public int getNumberDiners() {
        return numberDiners;
    }

    public void setNumberDiners(int numberDiners) {
        this.numberDiners = numberDiners;
    }

    public int getPreparationTime() {
        return preparationTime;
    }

    public void setPreparationTime(int preparationTime) {
        this.preparationTime = preparationTime;
    }

    public double getCalories() {
        return calories;
    }

    public void setCalories(double calories) {
        this.calories = calories;
    }

    public String getImage() {
        return image;
    }

    public void setImage(String image) {
        this.image = image;
    }
    
    
   
   
   
    
}
