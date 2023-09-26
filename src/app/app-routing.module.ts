import { CategoryListComponent } from './features/category/category-list/category-list.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCategoryComponent } from './features/category/add-category/add-category.component';

const routes: Routes = [
  { path: 'admin/categories', component: CategoryListComponent },
  { path: 'admin/categories/add', component: AddCategoryComponent },
  { path: '**', redirectTo: '/home' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }