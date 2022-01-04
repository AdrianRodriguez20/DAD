/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.dao;
import java.util.ArrayList;
/**
 *
 * @author Adrián Rodríguez Fuentes
 */

public interface Crud<T, E> {
	
	T save(T dao);

	T findById(E id);

	boolean update(T dao);

	boolean delete(E id);

	ArrayList<T> findAll();
}
