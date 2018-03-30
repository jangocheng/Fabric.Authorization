import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import {
  ButtonModule,
  IconModule,
  PopoverModule,
  InputModule,
  LabelModule,
  CheckboxModule
} from '@healthcatalyst/cashmere';

import { AccessControlRoutingModule } from './access-control-routing.module';
import {
  FabricBaseService,
  FabricAuthGroupService,
  FabricAuthMemberSearchService,
  FabricAuthUserService,
  FabricExternalIdpSearchService,
  FabricAuthRoleService
} from '../../services';

import { MemberListComponent } from './member-list/member-list.component';
import { MemberAddComponent } from './member-add/member-add.component';
import { CustomGroupAddComponent } from './custom-group-add/custom-group-add.component';
import { MemberEditComponent } from './member-edit/member-edit.component';
import { CustomGroupEditComponent } from './custom-group-edit/custom-group-edit.component';

@NgModule({
  imports: [
    CommonModule,
    AccessControlRoutingModule,
    FormsModule,
    // Cashmere modules
    ButtonModule,
    IconModule,
    PopoverModule,
    InputModule,
    LabelModule,
    CheckboxModule
  ],
  declarations: [
    MemberListComponent,
    MemberAddComponent,
    CustomGroupAddComponent,
    MemberEditComponent,
    CustomGroupEditComponent
  ],
  providers: [
    FabricBaseService,
    FabricAuthGroupService,
    FabricAuthMemberSearchService,
    FabricAuthUserService,
    FabricExternalIdpSearchService,
    FabricAuthRoleService
  ],
  exports: []
})
export class AccessControlModule {}
